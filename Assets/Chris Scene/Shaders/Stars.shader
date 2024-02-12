// Shader created with Shader Forge v1.38 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:2,rntp:3,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:34105,y:33165,varname:node_3138,prsc:2|emission-2070-OUT,clip-9137-OUT;n:type:ShaderForge.SFN_Tex2dAsset,id:1093,x:31381,y:32784,ptovrint:False,ptlb:StarsTextureRGB,ptin:_StarsTextureRGB,varname:_StarsTextureRGB,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:e44c95ed1564c4d438986b8e0e0458a1,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:8267,x:32156,y:32976,varname:node_8267,prsc:2,tex:e44c95ed1564c4d438986b8e0e0458a1,ntxv:0,isnm:False|UVIN-6941-OUT,TEX-1093-TEX;n:type:ShaderForge.SFN_Time,id:9842,x:31054,y:32979,varname:node_9842,prsc:2;n:type:ShaderForge.SFN_Multiply,id:7259,x:31381,y:33008,varname:node_7259,prsc:2|A-9842-TSL,B-1161-OUT;n:type:ShaderForge.SFN_Add,id:4724,x:31381,y:33435,varname:node_4724,prsc:2|A-7259-OUT,B-526-V;n:type:ShaderForge.SFN_ValueProperty,id:1161,x:31054,y:33184,ptovrint:False,ptlb:Speed1,ptin:_Speed1,varname:_Speed1,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:-6;n:type:ShaderForge.SFN_TexCoord,id:526,x:30821,y:33215,varname:node_526,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Append,id:6941,x:31772,y:33409,varname:node_6941,prsc:2|A-377-OUT,B-4724-OUT;n:type:ShaderForge.SFN_Add,id:2579,x:32647,y:33481,varname:node_2579,prsc:2|A-8267-R,B-4312-R;n:type:ShaderForge.SFN_Clamp01,id:6114,x:33139,y:33071,varname:node_6114,prsc:2|IN-4077-OUT;n:type:ShaderForge.SFN_RemapRange,id:9137,x:33330,y:33071,varname:node_9137,prsc:2,frmn:0.4,frmx:0.45,tomn:0,tomx:1|IN-6114-OUT;n:type:ShaderForge.SFN_TexCoord,id:8983,x:31373,y:32452,varname:node_8983,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_ValueProperty,id:9610,x:31373,y:32341,ptovrint:False,ptlb:SpeedDistort,ptin:_SpeedDistort,varname:_SpeedDistort,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:10;n:type:ShaderForge.SFN_Multiply,id:3288,x:31628,y:32341,varname:node_3288,prsc:2|A-9842-TSL,B-9610-OUT;n:type:ShaderForge.SFN_Add,id:7298,x:31843,y:32356,varname:node_7298,prsc:2|A-3288-OUT,B-8983-V;n:type:ShaderForge.SFN_Append,id:8757,x:32032,y:32285,varname:node_8757,prsc:2|A-8983-U,B-7298-OUT;n:type:ShaderForge.SFN_Multiply,id:8839,x:32632,y:32103,varname:node_8839,prsc:2|A-6439-OUT,B-6883-OUT;n:type:ShaderForge.SFN_RemapRange,id:6883,x:32460,y:32267,varname:node_6883,prsc:2,frmn:0.4,frmx:0.45,tomn:0,tomx:1|IN-3824-G;n:type:ShaderForge.SFN_ValueProperty,id:6439,x:32404,y:32116,ptovrint:False,ptlb:Distort,ptin:_Distort,varname:_Distort,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.06;n:type:ShaderForge.SFN_ObjectPosition,id:1100,x:31511,y:35035,varname:node_1100,prsc:2;n:type:ShaderForge.SFN_ViewPosition,id:4620,x:31340,y:35253,varname:node_4620,prsc:2;n:type:ShaderForge.SFN_Vector3,id:1958,x:31722,y:35123,varname:node_1958,prsc:2,v1:1,v2:0,v3:0;n:type:ShaderForge.SFN_Subtract,id:8217,x:31882,y:35032,varname:node_8217,prsc:2|A-1100-XYZ,B-1958-OUT;n:type:ShaderForge.SFN_Normalize,id:4449,x:32059,y:35032,varname:node_4449,prsc:2|IN-8217-OUT;n:type:ShaderForge.SFN_Subtract,id:8010,x:31864,y:35243,varname:node_8010,prsc:2|A-1100-XYZ,B-8081-OUT;n:type:ShaderForge.SFN_Vector1,id:2597,x:31468,y:35455,varname:node_2597,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Append,id:8081,x:31693,y:35406,varname:node_8081,prsc:2|A-4620-X,B-2597-OUT,C-4620-Z;n:type:ShaderForge.SFN_Normalize,id:5865,x:32059,y:35243,varname:node_5865,prsc:2|IN-8010-OUT;n:type:ShaderForge.SFN_Dot,id:1711,x:32292,y:35112,varname:node_1711,prsc:2,dt:0|A-4449-OUT,B-5865-OUT;n:type:ShaderForge.SFN_Cross,id:9794,x:32292,y:35307,varname:node_9794,prsc:2|A-4449-OUT,B-5865-OUT;n:type:ShaderForge.SFN_ArcTan2,id:8707,x:32484,y:35245,varname:node_8707,prsc:2,attp:2|A-1711-OUT,B-9794-OUT;n:type:ShaderForge.SFN_ComponentMask,id:1837,x:32680,y:35245,varname:node_1837,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-8707-OUT;n:type:ShaderForge.SFN_Add,id:377,x:31381,y:33203,varname:node_377,prsc:2|A-526-U,B-1229-OUT,C-8839-OUT;n:type:ShaderForge.SFN_Multiply,id:1229,x:32871,y:35048,varname:node_1229,prsc:2|A-6993-OUT,B-1837-OUT;n:type:ShaderForge.SFN_ValueProperty,id:6993,x:32556,y:34999,ptovrint:False,ptlb:CameraOffset,ptin:_CameraOffset,varname:_CameraOffset,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:6;n:type:ShaderForge.SFN_Tex2d,id:9406,x:31935,y:33502,varname:node_9406,prsc:2,tex:e44c95ed1564c4d438986b8e0e0458a1,ntxv:0,isnm:False|TEX-1093-TEX;n:type:ShaderForge.SFN_Tex2d,id:3824,x:32247,y:32220,varname:node_3824,prsc:2,tex:e44c95ed1564c4d438986b8e0e0458a1,ntxv:0,isnm:False|UVIN-8757-OUT,TEX-1093-TEX;n:type:ShaderForge.SFN_TexCoord,id:2889,x:31192,y:33972,varname:node_2889,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Add,id:1891,x:31429,y:34053,varname:node_1891,prsc:2|A-7743-OUT,B-2889-V,C-6173-OUT;n:type:ShaderForge.SFN_Append,id:2280,x:31680,y:34000,varname:node_2280,prsc:2|A-9225-OUT,B-1891-OUT;n:type:ShaderForge.SFN_Tex2d,id:4312,x:32113,y:33813,varname:node_4312,prsc:2,tex:e44c95ed1564c4d438986b8e0e0458a1,ntxv:0,isnm:False|UVIN-2280-OUT,TEX-1093-TEX;n:type:ShaderForge.SFN_ValueProperty,id:4522,x:31063,y:33660,ptovrint:False,ptlb:Speed2,ptin:_Speed2,varname:_Speed2,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:-2;n:type:ShaderForge.SFN_Multiply,id:7743,x:31241,y:33637,varname:node_7743,prsc:2|A-9842-TSL,B-4522-OUT;n:type:ShaderForge.SFN_Add,id:9225,x:31462,y:33822,varname:node_9225,prsc:2|A-2889-U,B-8869-OUT,C-8839-OUT;n:type:ShaderForge.SFN_Negate,id:8869,x:33047,y:34844,varname:node_8869,prsc:2|IN-1229-OUT;n:type:ShaderForge.SFN_Vector1,id:6173,x:31173,y:34218,varname:node_6173,prsc:2,v1:0.5;n:type:ShaderForge.SFN_TexCoord,id:4961,x:30994,y:34544,varname:node_4961,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_RemapRange,id:94,x:31242,y:34565,varname:node_94,prsc:2,frmn:0,frmx:1,tomn:-1,tomx:1|IN-4961-U;n:type:ShaderForge.SFN_Abs,id:7119,x:31457,y:34565,varname:node_7119,prsc:2|IN-94-OUT;n:type:ShaderForge.SFN_RemapRange,id:15,x:31689,y:34565,varname:node_15,prsc:2,frmn:0,frmx:1,tomn:-1,tomx:1|IN-7119-OUT;n:type:ShaderForge.SFN_Clamp01,id:929,x:31880,y:34565,varname:node_929,prsc:2|IN-15-OUT;n:type:ShaderForge.SFN_OneMinus,id:3412,x:32060,y:34565,varname:node_3412,prsc:2|IN-929-OUT;n:type:ShaderForge.SFN_Multiply,id:8696,x:32733,y:33690,varname:node_8696,prsc:2|A-2579-OUT,B-3412-OUT;n:type:ShaderForge.SFN_Add,id:4077,x:32972,y:33630,varname:node_4077,prsc:2|A-8696-OUT,B-9406-B;n:type:ShaderForge.SFN_Color,id:756,x:33565,y:32817,ptovrint:False,ptlb:Color2,ptin:_Color2,varname:_Color2,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.9294118,c2:0.6719356,c3:0.4268423,c4:1;n:type:ShaderForge.SFN_Color,id:1136,x:33565,y:32571,ptovrint:False,ptlb:Color1,ptin:_Color1,varname:_Color1,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.9607843,c2:0.8396163,c3:0.6392157,c4:1;n:type:ShaderForge.SFN_Lerp,id:2070,x:33851,y:32675,varname:node_2070,prsc:2|A-1136-RGB,B-756-RGB,T-3868-OUT;n:type:ShaderForge.SFN_Add,id:3868,x:32705,y:32873,varname:node_3868,prsc:2|A-8267-R,B-9406-B;proporder:1093-1161-9610-6439-6993-4522-756-1136;pass:END;sub:END;*/

Shader "Shader Forge/Stars" {
    Properties {
        _StarsTextureRGB ("StarsTextureRGB", 2D) = "white" {}
        _Speed1 ("Speed1", Float ) = -6
        _SpeedDistort ("SpeedDistort", Float ) = 10
        _Distort ("Distort", Float ) = 0.06
        _CameraOffset ("CameraOffset", Float ) = 6
        _Speed2 ("Speed2", Float ) = -2
        _Color2 ("Color2", Color) = (0.9294118,0.6719356,0.4268423,1)
        _Color1 ("Color1", Color) = (0.9607843,0.8396163,0.6392157,1)
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "Queue"="AlphaTest"
            "RenderType"="TransparentCutout"
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
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _StarsTextureRGB; uniform float4 _StarsTextureRGB_ST;
            uniform float _Speed1;
            uniform float _SpeedDistort;
            uniform float _Distort;
            uniform float _CameraOffset;
            uniform float _Speed2;
            uniform float4 _Color2;
            uniform float4 _Color1;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 node_4449 = normalize((objPos.rgb-float3(1,0,0)));
                float3 node_5865 = normalize((objPos.rgb-float3(_WorldSpaceCameraPos.r,0.5,_WorldSpaceCameraPos.b)));
                float node_1229 = (_CameraOffset*((atan2(dot(node_4449,node_5865),cross(node_4449,node_5865))/6.28318530718)+0.5).g);
                float4 node_9842 = _Time;
                float2 node_8757 = float2(i.uv0.r,((node_9842.r*_SpeedDistort)+i.uv0.g));
                float4 node_3824 = tex2D(_StarsTextureRGB,TRANSFORM_TEX(node_8757, _StarsTextureRGB));
                float node_8839 = (_Distort*(node_3824.g*20.00001+-8.000003));
                float2 node_6941 = float2((i.uv0.r+node_1229+node_8839),((node_9842.r*_Speed1)+i.uv0.g));
                float4 node_8267 = tex2D(_StarsTextureRGB,TRANSFORM_TEX(node_6941, _StarsTextureRGB));
                float2 node_2280 = float2((i.uv0.r+(-1*node_1229)+node_8839),((node_9842.r*_Speed2)+i.uv0.g+0.5));
                float4 node_4312 = tex2D(_StarsTextureRGB,TRANSFORM_TEX(node_2280, _StarsTextureRGB));
                float4 node_9406 = tex2D(_StarsTextureRGB,TRANSFORM_TEX(i.uv0, _StarsTextureRGB));
                clip((saturate((((node_8267.r+node_4312.r)*(1.0 - saturate((abs((i.uv0.r*2.0+-1.0))*2.0+-1.0))))+node_9406.b))*20.00001+-8.000003) - 0.5);
////// Lighting:
////// Emissive:
                float3 emissive = lerp(_Color1.rgb,_Color2.rgb,(node_8267.r+node_9406.b));
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            Cull Back
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _StarsTextureRGB; uniform float4 _StarsTextureRGB_ST;
            uniform float _Speed1;
            uniform float _SpeedDistort;
            uniform float _Distort;
            uniform float _CameraOffset;
            uniform float _Speed2;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                float3 node_4449 = normalize((objPos.rgb-float3(1,0,0)));
                float3 node_5865 = normalize((objPos.rgb-float3(_WorldSpaceCameraPos.r,0.5,_WorldSpaceCameraPos.b)));
                float node_1229 = (_CameraOffset*((atan2(dot(node_4449,node_5865),cross(node_4449,node_5865))/6.28318530718)+0.5).g);
                float4 node_9842 = _Time;
                float2 node_8757 = float2(i.uv0.r,((node_9842.r*_SpeedDistort)+i.uv0.g));
                float4 node_3824 = tex2D(_StarsTextureRGB,TRANSFORM_TEX(node_8757, _StarsTextureRGB));
                float node_8839 = (_Distort*(node_3824.g*20.00001+-8.000003));
                float2 node_6941 = float2((i.uv0.r+node_1229+node_8839),((node_9842.r*_Speed1)+i.uv0.g));
                float4 node_8267 = tex2D(_StarsTextureRGB,TRANSFORM_TEX(node_6941, _StarsTextureRGB));
                float2 node_2280 = float2((i.uv0.r+(-1*node_1229)+node_8839),((node_9842.r*_Speed2)+i.uv0.g+0.5));
                float4 node_4312 = tex2D(_StarsTextureRGB,TRANSFORM_TEX(node_2280, _StarsTextureRGB));
                float4 node_9406 = tex2D(_StarsTextureRGB,TRANSFORM_TEX(i.uv0, _StarsTextureRGB));
                clip((saturate((((node_8267.r+node_4312.r)*(1.0 - saturate((abs((i.uv0.r*2.0+-1.0))*2.0+-1.0))))+node_9406.b))*20.00001+-8.000003) - 0.5);
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
