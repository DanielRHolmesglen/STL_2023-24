// Shader created with Shader Forge v1.38 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:32719,y:32712,varname:node_3138,prsc:2|emission-7142-OUT;n:type:ShaderForge.SFN_Lerp,id:7142,x:31883,y:32720,varname:node_7142,prsc:2|A-521-RGB,B-4667-RGB,T-4107-OUT;n:type:ShaderForge.SFN_Tex2d,id:521,x:31497,y:32585,varname:node_521,prsc:2,tex:5cc3cc8f7c378a74984b94b00bc924c1,ntxv:0,isnm:False|TEX-9232-TEX;n:type:ShaderForge.SFN_Tex2d,id:4667,x:31497,y:32810,varname:node_4667,prsc:2,tex:4f4dff1569be963408c58a9d2c30dcb0,ntxv:0,isnm:False|TEX-2020-TEX;n:type:ShaderForge.SFN_Time,id:2781,x:31413,y:32339,varname:node_2781,prsc:2;n:type:ShaderForge.SFN_Tex2dAsset,id:9232,x:31325,y:32596,ptovrint:False,ptlb:LineTop,ptin:_LineTop,varname:node_9232,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:5cc3cc8f7c378a74984b94b00bc924c1,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2dAsset,id:2020,x:31324,y:32821,ptovrint:False,ptlb:LineBottom,ptin:_LineBottom,varname:node_2020,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:4f4dff1569be963408c58a9d2c30dcb0,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Slider,id:2762,x:31616,y:32190,ptovrint:False,ptlb:Progress,ptin:_Progress,varname:node_2762,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:10;n:type:ShaderForge.SFN_Multiply,id:4107,x:31704,y:32334,varname:node_4107,prsc:2|A-2781-TSL,B-2762-OUT;proporder:9232-2020-2762;pass:END;sub:END;*/

Shader "Shader Forge/LineLerp" {
    Properties {
        _LineTop ("LineTop", 2D) = "white" {}
        _LineBottom ("LineBottom", 2D) = "white" {}
        _Progress ("Progress", Range(0, 10)) = 0
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _LineTop; uniform float4 _LineTop_ST;
            uniform sampler2D _LineBottom; uniform float4 _LineBottom_ST;
            uniform float _Progress;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = UnityObjectToClipPos( v.vertex );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
////// Lighting:
////// Emissive:
                float4 node_521 = tex2D(_LineTop,TRANSFORM_TEX(i.uv0, _LineTop));
                float4 node_4667 = tex2D(_LineBottom,TRANSFORM_TEX(i.uv0, _LineBottom));
                float4 node_2781 = _Time;
                float3 emissive = lerp(node_521.rgb,node_4667.rgb,(node_2781.r*_Progress));
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
