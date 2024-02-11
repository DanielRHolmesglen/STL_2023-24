// Shader created with Shader Forge v1.38 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:33509,y:32237,varname:node_3138,prsc:2|emission-967-OUT;n:type:ShaderForge.SFN_Time,id:7032,x:32609,y:32644,varname:node_7032,prsc:2;n:type:ShaderForge.SFN_Tex2dAsset,id:6884,x:32984,y:32578,ptovrint:False,ptlb:Texture Image,ptin:_TextureImage,varname:_TextureImage,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:7e36f2ea06207da4d8c25ff499602401,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:3846,x:33256,y:32538,varname:node_3846,prsc:2,tex:7e36f2ea06207da4d8c25ff499602401,ntxv:2,isnm:False|UVIN-7391-OUT,TEX-6884-TEX;n:type:ShaderForge.SFN_Add,id:6639,x:32958,y:32771,varname:node_6639,prsc:2|A-8412-OUT,B-3094-V;n:type:ShaderForge.SFN_Multiply,id:8412,x:32810,y:32644,varname:node_8412,prsc:2|A-7032-TSL,B-3186-OUT;n:type:ShaderForge.SFN_TexCoord,id:3094,x:32609,y:32894,varname:node_3094,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Append,id:7391,x:33108,y:32903,varname:node_7391,prsc:2|A-3094-U,B-6639-OUT;n:type:ShaderForge.SFN_Multiply,id:967,x:33268,y:32338,varname:node_967,prsc:2|A-3735-RGB,B-3846-RGB;n:type:ShaderForge.SFN_ValueProperty,id:3186,x:32609,y:32556,ptovrint:False,ptlb:Speed,ptin:_Speed,varname:_Speed,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:12;n:type:ShaderForge.SFN_Color,id:3735,x:32984,y:32334,ptovrint:False,ptlb:Color,ptin:_Color,varname:_Color,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.8117647,c2:0.8,c3:0.2431373,c4:1;proporder:6884-3186-3735;pass:END;sub:END;*/

Shader "Shader Forge/Background_Shader" {
    Properties {
        _TextureImage ("Texture Image", 2D) = "white" {}
        _Speed ("Speed", Float ) = 12
        _Color ("Color", Color) = (0.8117647,0.8,0.2431373,1)
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
            #pragma target 3.0
            uniform sampler2D _TextureImage; uniform float4 _TextureImage_ST;
            uniform float _Speed;
            uniform float4 _Color;
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
                float4 node_7032 = _Time;
                float2 node_7391 = float2(i.uv0.r,((node_7032.r*_Speed)+i.uv0.g));
                float4 node_3846 = tex2D(_TextureImage,TRANSFORM_TEX(node_7391, _TextureImage));
                float3 emissive = (_Color.rgb*node_3846.rgb);
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
