// Shader created with Shader Forge v1.38 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:33523,y:33012,varname:node_3138,prsc:2|voffset-8919-OUT;n:type:ShaderForge.SFN_LightVector,id:4046,x:30435,y:31741,varname:node_4046,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:4976,x:30435,y:31555,prsc:2,pt:False;n:type:ShaderForge.SFN_Dot,id:4012,x:30634,y:31555,varname:node_4012,prsc:2,dt:0|A-4976-OUT,B-4046-OUT;n:type:ShaderForge.SFN_Subtract,id:4025,x:30841,y:31555,varname:node_4025,prsc:2|A-4012-OUT,B-9874-OUT;n:type:ShaderForge.SFN_Vector1,id:9874,x:30634,y:31762,varname:node_9874,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Vector1,id:4124,x:30841,y:31762,varname:node_4124,prsc:2,v1:-1;n:type:ShaderForge.SFN_Multiply,id:3562,x:31044,y:31555,varname:node_3562,prsc:2|A-4025-OUT,B-4124-OUT;n:type:ShaderForge.SFN_Multiply,id:9775,x:31247,y:31555,varname:node_9775,prsc:2|A-3562-OUT;n:type:ShaderForge.SFN_Tex2d,id:6706,x:31044,y:31780,ptovrint:False,ptlb:LightMap,ptin:_LightMap,varname:node_6706,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:2,isnm:False;n:type:ShaderForge.SFN_Multiply,id:2783,x:31659,y:31555,varname:node_2783,prsc:2|A-9775-OUT,B-8671-OUT;n:type:ShaderForge.SFN_Multiply,id:8671,x:31445,y:31782,varname:node_8671,prsc:2|A-6706-RGB,B-4299-OUT;n:type:ShaderForge.SFN_Color,id:8249,x:31044,y:31988,ptovrint:False,ptlb:LightColor,ptin:_LightColor,varname:node_8249,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Multiply,id:4299,x:31235,y:31988,varname:node_4299,prsc:2|A-8249-RGB,B-9605-OUT;n:type:ShaderForge.SFN_Slider,id:9605,x:30887,y:32206,ptovrint:False,ptlb:LightIntensity,ptin:_LightIntensity,varname:node_9605,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:2;n:type:ShaderForge.SFN_Desaturate,id:4485,x:31902,y:31450,varname:node_4485,prsc:2|COL-2783-OUT;n:type:ShaderForge.SFN_Tex2d,id:1494,x:32623,y:31969,ptovrint:False,ptlb:TextureMap,ptin:_TextureMap,varname:_LightMap_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:2,isnm:False;n:type:ShaderForge.SFN_Multiply,id:4931,x:32827,y:32409,varname:node_4931,prsc:2|A-1494-RGB,B-2459-RGB;n:type:ShaderForge.SFN_Multiply,id:1433,x:32015,y:32399,varname:node_1433,prsc:2|A-5848-RGB,B-8185-RGB;n:type:ShaderForge.SFN_Subtract,id:5588,x:32620,y:32692,varname:node_5588,prsc:2|A-4485-OUT;n:type:ShaderForge.SFN_Add,id:5811,x:33035,y:32389,varname:node_5811,prsc:2|A-2783-OUT,B-4931-OUT;n:type:ShaderForge.SFN_Color,id:2459,x:32620,y:32508,ptovrint:False,ptlb:TextureColor,ptin:_TextureColor,varname:_LightColor_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Multiply,id:2843,x:32234,y:32478,varname:node_2843,prsc:2|A-1433-OUT,B-8704-OUT;n:type:ShaderForge.SFN_Slider,id:8704,x:31916,y:32692,ptovrint:False,ptlb:CloudMapSpec,ptin:_CloudMapSpec,varname:_LightIntensity_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:0,max:1;n:type:ShaderForge.SFN_Subtract,id:529,x:32415,y:32810,varname:node_529,prsc:2|A-5611-OUT,B-2843-OUT;n:type:ShaderForge.SFN_Multiply,id:4305,x:32620,y:32914,varname:node_4305,prsc:2|A-529-OUT,B-2078-OUT;n:type:ShaderForge.SFN_Clamp01,id:9622,x:32833,y:32692,varname:node_9622,prsc:2|IN-5588-OUT;n:type:ShaderForge.SFN_Slider,id:3214,x:31745,y:32975,ptovrint:False,ptlb:SpecMapIntensity,ptin:_SpecMapIntensity,varname:_CloudMapSpec_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.4,max:1;n:type:ShaderForge.SFN_Slider,id:2078,x:32138,y:33044,ptovrint:False,ptlb:Smoothness,ptin:_Smoothness,varname:_CloudMapSpec_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Multiply,id:5611,x:32217,y:32810,varname:node_5611,prsc:2|A-730-RGB,B-3214-OUT;n:type:ShaderForge.SFN_Tex2d,id:730,x:31824,y:32789,ptovrint:False,ptlb:SpecularMap,ptin:_SpecularMap,varname:_TextureMap_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:2,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:964,x:32620,y:33105,ptovrint:False,ptlb:NormalMap,ptin:_NormalMap,varname:_SpecularMap_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:3,isnm:False;n:type:ShaderForge.SFN_ComponentMask,id:6053,x:32826,y:33094,varname:node_6053,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-964-RGB;n:type:ShaderForge.SFN_Multiply,id:1699,x:33009,y:33094,varname:node_1699,prsc:2|A-6053-OUT,B-6054-OUT;n:type:ShaderForge.SFN_Vector1,id:9791,x:32961,y:33299,varname:node_9791,prsc:2,v1:1;n:type:ShaderForge.SFN_ValueProperty,id:6054,x:32775,y:33299,ptovrint:False,ptlb:NormalMapIntensity,ptin:_NormalMapIntensity,varname:node_6054,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Tex2d,id:5848,x:31741,y:32404,ptovrint:False,ptlb:CloudMap,ptin:_CloudMap,varname:_TextureMap_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:2,isnm:False|UVIN-1582-UVOUT;n:type:ShaderForge.SFN_Color,id:8185,x:31741,y:32596,ptovrint:False,ptlb:CloudColor,ptin:_CloudColor,varname:_LightColor_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Panner,id:1582,x:31537,y:32404,varname:node_1582,prsc:2,spu:0.05,spv:0|UVIN-67-UVOUT,DIST-3655-OUT;n:type:ShaderForge.SFN_TexCoord,id:67,x:31307,y:32404,varname:node_67,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:3655,x:31388,y:32598,varname:node_3655,prsc:2|A-7767-T,B-6305-OUT;n:type:ShaderForge.SFN_Slider,id:6305,x:30959,y:32739,ptovrint:False,ptlb:CloudPanSpeed,ptin:_CloudPanSpeed,varname:_CloudMapSpec_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:0,max:1;n:type:ShaderForge.SFN_Time,id:7767,x:31116,y:32552,varname:node_7767,prsc:2;n:type:ShaderForge.SFN_Vector1,id:9425,x:30888,y:33270,varname:node_9425,prsc:2,v1:8;n:type:ShaderForge.SFN_Subtract,id:972,x:31181,y:33366,varname:node_972,prsc:2|A-9425-OUT,B-9708-OUT;n:type:ShaderForge.SFN_Slider,id:9708,x:30721,y:33443,ptovrint:False,ptlb:AtmosphereDensity,ptin:_AtmosphereDensity,varname:_CloudPanSpeed_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:8;n:type:ShaderForge.SFN_Fresnel,id:4361,x:31370,y:33363,varname:node_4361,prsc:2|EXP-972-OUT;n:type:ShaderForge.SFN_Color,id:2132,x:31370,y:33555,ptovrint:False,ptlb:AtmosphereColor,ptin:_AtmosphereColor,varname:_CloudColor_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.4,c2:0.6,c3:1,c4:1;n:type:ShaderForge.SFN_Multiply,id:9140,x:31582,y:33555,varname:node_9140,prsc:2|A-4361-OUT,B-2132-RGB;n:type:ShaderForge.SFN_NormalVector,id:6701,x:30945,y:33668,prsc:2,pt:False;n:type:ShaderForge.SFN_LightVector,id:7046,x:30945,y:33828,varname:node_7046,prsc:2;n:type:ShaderForge.SFN_Slider,id:3607,x:31115,y:33988,ptovrint:False,ptlb:LightStretch,ptin:_LightStretch,varname:_AtmosphereDensity_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:0.5;n:type:ShaderForge.SFN_Dot,id:9186,x:31228,y:33779,varname:node_9186,prsc:2,dt:0|A-6701-OUT,B-7046-OUT;n:type:ShaderForge.SFN_Add,id:2362,x:31439,y:33779,varname:node_2362,prsc:2|A-9186-OUT,B-3607-OUT;n:type:ShaderForge.SFN_Clamp01,id:2145,x:31619,y:33779,varname:node_2145,prsc:2|IN-2362-OUT;n:type:ShaderForge.SFN_Slider,id:4882,x:31743,y:34042,ptovrint:False,ptlb:HeightMapIntensity,ptin:_HeightMapIntensity,varname:_LightStretch_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:5,max:5;n:type:ShaderForge.SFN_Vector1,id:5559,x:31900,y:33918,varname:node_5559,prsc:2,v1:0.01;n:type:ShaderForge.SFN_Multiply,id:3931,x:31813,y:33555,varname:node_3931,prsc:2|A-9140-OUT,B-2145-OUT;n:type:ShaderForge.SFN_Add,id:3850,x:32105,y:33308,varname:node_3850,prsc:2;n:type:ShaderForge.SFN_Tex2d,id:4100,x:32126,y:34140,ptovrint:False,ptlb:HeightMap,ptin:_HeightMap,varname:_NormalMap_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:2,isnm:False;n:type:ShaderForge.SFN_Multiply,id:5157,x:32126,y:33918,varname:node_5157,prsc:2|A-5559-OUT,B-4882-OUT;n:type:ShaderForge.SFN_Multiply,id:230,x:32339,y:33918,varname:node_230,prsc:2|A-5157-OUT,B-4100-RGB;n:type:ShaderForge.SFN_Multiply,id:8919,x:32544,y:33918,varname:node_8919,prsc:2|A-230-OUT,B-966-OUT;n:type:ShaderForge.SFN_NormalVector,id:966,x:32339,y:34140,prsc:2,pt:False;n:type:ShaderForge.SFN_Append,id:4179,x:33221,y:33094,varname:node_4179,prsc:2|A-1699-OUT,B-9791-OUT;n:type:ShaderForge.SFN_Add,id:8838,x:33241,y:32363,varname:node_8838,prsc:2|A-1433-OUT,B-5811-OUT;n:type:ShaderForge.SFN_Add,id:6263,x:33004,y:33401,varname:node_6263,prsc:2|A-9622-OUT;proporder:964-6054-4882-4100-6706-8249-9605-1494-2459-5848-8185-6305;pass:END;sub:END;*/

Shader "Shader Forge/Planets" {
    Properties {
        _NormalMap ("NormalMap", 2D) = "bump" {}
        _NormalMapIntensity ("NormalMapIntensity", Float ) = 1
        _HeightMapIntensity ("HeightMapIntensity", Range(0, 5)) = 5
        _HeightMap ("HeightMap", 2D) = "black" {}
        _LightMap ("LightMap", 2D) = "black" {}
        _LightColor ("LightColor", Color) = (1,1,1,1)
        _LightIntensity ("LightIntensity", Range(0, 2)) = 0
        _TextureMap ("TextureMap", 2D) = "black" {}
        _TextureColor ("TextureColor", Color) = (1,1,1,1)
        _CloudMap ("CloudMap", 2D) = "black" {}
        _CloudColor ("CloudColor", Color) = (1,1,1,1)
        _CloudPanSpeed ("CloudPanSpeed", Range(-1, 1)) = 0
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
            uniform float _HeightMapIntensity;
            uniform sampler2D _HeightMap; uniform float4 _HeightMap_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float3 normalDir : TEXCOORD1;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 _HeightMap_var = tex2Dlod(_HeightMap,float4(TRANSFORM_TEX(o.uv0, _HeightMap),0.0,0));
                v.vertex.xyz += (((0.01*_HeightMapIntensity)*_HeightMap_var.rgb)*v.normal);
                o.pos = UnityObjectToClipPos( v.vertex );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
////// Lighting:
                float3 finalColor = 0;
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
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float _HeightMapIntensity;
            uniform sampler2D _HeightMap; uniform float4 _HeightMap_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 _HeightMap_var = tex2Dlod(_HeightMap,float4(TRANSFORM_TEX(o.uv0, _HeightMap),0.0,0));
                v.vertex.xyz += (((0.01*_HeightMapIntensity)*_HeightMap_var.rgb)*v.normal);
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
