// Shader created with Shader Forge v1.38 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:4013,x:33407,y:32393,varname:node_4013,prsc:2|diff-5715-OUT,diffpow-526-OUT,spec-526-OUT,gloss-6490-OUT,normal-4567-OUT,alpha-4577-OUT,refract-3577-OUT;n:type:ShaderForge.SFN_Slider,id:1881,x:32436,y:33299,ptovrint:False,ptlb:Opacity,ptin:_Opacity,varname:node_1881,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:6168,x:32436,y:33480,ptovrint:False,ptlb:Invisibility,ptin:_Invisibility,varname:_node_1881_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:3;n:type:ShaderForge.SFN_Fresnel,id:522,x:32826,y:33457,varname:node_522,prsc:2|EXP-6168-OUT;n:type:ShaderForge.SFN_Vector1,id:477,x:32826,y:33246,varname:node_477,prsc:2,v1:1;n:type:ShaderForge.SFN_Lerp,id:4577,x:33020,y:33295,varname:node_4577,prsc:2|A-522-OUT,B-477-OUT,T-1881-OUT;n:type:ShaderForge.SFN_Multiply,id:3577,x:33087,y:33452,varname:node_3577,prsc:2|A-8879-UVOUT,B-522-OUT;n:type:ShaderForge.SFN_TexCoord,id:8879,x:32837,y:33595,varname:node_8879,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_NormalVector,id:7580,x:29360,y:32329,prsc:2,pt:False;n:type:ShaderForge.SFN_Transform,id:8247,x:29538,y:32168,varname:node_8247,prsc:2,tffrom:0,tfto:1|IN-7580-OUT;n:type:ShaderForge.SFN_SwitchProperty,id:8571,x:29709,y:32446,ptovrint:False,ptlb:Local/Global,ptin:_LocalGlobal,varname:node_8571,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-8247-XYZ,B-7580-OUT;n:type:ShaderForge.SFN_Abs,id:4826,x:29901,y:32569,varname:node_4826,prsc:2|IN-8571-OUT;n:type:ShaderForge.SFN_Multiply,id:6619,x:30065,y:32369,varname:node_6619,prsc:2|A-8571-OUT,B-4826-OUT;n:type:ShaderForge.SFN_ComponentMask,id:6858,x:30253,y:32369,cmnt:G component from RGB,varname:node_6858,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-6619-OUT;n:type:ShaderForge.SFN_Subtract,id:8412,x:30554,y:32387,cmnt:Remove G info to get cracks,varname:node_8412,prsc:2|A-6858-OUT,B-7334-G;n:type:ShaderForge.SFN_Tex2d,id:7334,x:30555,y:32631,ptovrint:False,ptlb:NormalMap1,ptin:_NormalMap1,varname:node_7334,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:3,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:3792,x:30555,y:32875,ptovrint:False,ptlb:NormalMap2,ptin:_NormalMap2,varname:_node_7334_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:3,isnm:False;n:type:ShaderForge.SFN_Slider,id:3383,x:30591,y:32203,ptovrint:False,ptlb:PlanetDarkness,ptin:_PlanetDarkness,varname:_Transparency_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:1,max:1;n:type:ShaderForge.SFN_ConstantClamp,id:9655,x:30986,y:32081,varname:node_9655,prsc:2,min:0,max:1|IN-3383-OUT;n:type:ShaderForge.SFN_Clamp01,id:8815,x:31196,y:32262,cmnt:Removes negative info which includes G values at the bottom,varname:node_8815,prsc:2|IN-2923-OUT;n:type:ShaderForge.SFN_Multiply,id:2923,x:30978,y:32262,varname:node_2923,prsc:2|A-8412-OUT,B-3383-OUT;n:type:ShaderForge.SFN_Vector1,id:9505,x:30867,y:31942,varname:node_9505,prsc:2,v1:0.7;n:type:ShaderForge.SFN_Multiply,id:8895,x:31399,y:32090,varname:node_8895,prsc:2|A-9505-OUT,B-9655-OUT,C-8815-OUT;n:type:ShaderForge.SFN_ConstantClamp,id:2792,x:30979,y:32616,cmnt:Choosing a smaller range of info,varname:node_2792,prsc:2,min:0,max:1|IN-7334-G;n:type:ShaderForge.SFN_Multiply,id:4274,x:31299,y:32611,cmnt:Added freezing effect,varname:node_4274,prsc:2|A-2792-OUT,B-3312-OUT;n:type:ShaderForge.SFN_Add,id:3801,x:31639,y:32385,cmnt:Added freezing effect,varname:node_3801,prsc:2|A-8895-OUT,B-4274-OUT;n:type:ShaderForge.SFN_Lerp,id:4567,x:32598,y:33102,varname:node_4567,prsc:2|A-7334-RGB,B-3792-RGB,T-3801-OUT;n:type:ShaderForge.SFN_Slider,id:3312,x:30958,y:33115,ptovrint:False,ptlb:ColorSeep,ptin:_ColorSeep,varname:_SnowSlider_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:5,cur:7,max:10;n:type:ShaderForge.SFN_Lerp,id:526,x:32605,y:32600,varname:node_526,prsc:2|A-6715-OUT,B-689-OUT,T-3801-OUT;n:type:ShaderForge.SFN_Lerp,id:2148,x:32271,y:32130,varname:node_2148,prsc:2|A-3137-RGB,B-2452-RGB,T-3801-OUT;n:type:ShaderForge.SFN_Vector1,id:689,x:32293,y:32673,varname:node_689,prsc:2,v1:0.1;n:type:ShaderForge.SFN_Vector1,id:972,x:32293,y:32904,varname:node_972,prsc:2,v1:0.7;n:type:ShaderForge.SFN_Slider,id:4707,x:32181,y:32766,ptovrint:False,ptlb:Gloss,ptin:_Gloss,varname:_SnowSlider_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.8,max:1;n:type:ShaderForge.SFN_Tex2d,id:2452,x:31995,y:32277,ptovrint:False,ptlb:Snow,ptin:_Snow,varname:_NormalMap2,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:649fcca1a6b895d4da87912f0c450f27,ntxv:3,isnm:False;n:type:ShaderForge.SFN_Color,id:3137,x:31995,y:32039,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_3137,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Slider,id:6715,x:32231,y:32445,ptovrint:False,ptlb:WhiteAdded,ptin:_WhiteAdded,varname:_Metallic_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Lerp,id:6490,x:32605,y:32754,varname:node_6490,prsc:2|A-4707-OUT,B-972-OUT,T-3801-OUT;n:type:ShaderForge.SFN_Color,id:8587,x:32859,y:32320,ptovrint:False,ptlb:BaseColor,ptin:_BaseColor,varname:node_8587,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.745283,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Multiply,id:5721,x:32653,y:32129,varname:node_5721,prsc:2|A-3137-RGB,B-2148-OUT;n:type:ShaderForge.SFN_Multiply,id:5715,x:33084,y:32200,varname:node_5715,prsc:2|A-5721-OUT,B-8587-RGB;proporder:6168-1881-8571-7334-3383-3312-2452-3137-3792-4707-6715-8587;pass:END;sub:END;*/

Shader "Shader Forge/PlanetShaderLit" {
    Properties {
        _Invisibility ("Invisibility", Range(0, 3)) = 0
        _Opacity ("Opacity", Range(-1, 1)) = 0
        [MaterialToggle] _LocalGlobal ("Local/Global", Float ) = 0
        _NormalMap1 ("NormalMap1", 2D) = "bump" {}
        _PlanetDarkness ("PlanetDarkness", Range(-1, 1)) = 1
        _ColorSeep ("ColorSeep", Range(5, 10)) = 7
        _Snow ("Snow", 2D) = "bump" {}
        _Color ("Color", Color) = (0.5,0.5,0.5,1)
        _NormalMap2 ("NormalMap2", 2D) = "bump" {}
        _Gloss ("Gloss", Range(0, 1)) = 0.8
        _WhiteAdded ("WhiteAdded", Range(0, 1)) = 0
        _BaseColor ("BaseColor", Color) = (0.745283,0,0,1)
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        GrabPass{ }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _GrabTexture;
            uniform float _Opacity;
            uniform float _Invisibility;
            uniform fixed _LocalGlobal;
            uniform sampler2D _NormalMap1; uniform float4 _NormalMap1_ST;
            uniform sampler2D _NormalMap2; uniform float4 _NormalMap2_ST;
            uniform float _PlanetDarkness;
            uniform float _ColorSeep;
            uniform float _Gloss;
            uniform sampler2D _Snow; uniform float4 _Snow_ST;
            uniform float4 _Color;
            uniform float _WhiteAdded;
            uniform float4 _BaseColor;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                float4 projPos : TEXCOORD5;
                UNITY_FOG_COORDS(6)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float4 _NormalMap1_var = tex2D(_NormalMap1,TRANSFORM_TEX(i.uv0, _NormalMap1));
                float4 _NormalMap2_var = tex2D(_NormalMap2,TRANSFORM_TEX(i.uv0, _NormalMap2));
                float3 _LocalGlobal_var = lerp( mul( unity_WorldToObject, float4(i.normalDir,0) ).xyz.rgb, i.normalDir, _LocalGlobal );
                float node_3801 = ((0.7*clamp(_PlanetDarkness,0,1)*saturate((((_LocalGlobal_var*abs(_LocalGlobal_var)).g-_NormalMap1_var.g)*_PlanetDarkness)))+(clamp(_NormalMap1_var.g,0,1)*_ColorSeep)); // Added freezing effect
                float3 normalLocal = lerp(_NormalMap1_var.rgb,_NormalMap2_var.rgb,node_3801);
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float node_522 = pow(1.0-max(0,dot(normalDirection, viewDirection)),_Invisibility);
                float2 sceneUVs = (i.projPos.xy / i.projPos.w) + (i.uv0*node_522);
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = 1;
                float3 attenColor = attenuation * _LightColor0.xyz;
///////// Gloss:
                float gloss = lerp(_Gloss,0.7,node_3801);
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float node_526 = lerp(_WhiteAdded,0.1,node_3801);
                float3 specularColor = float3(node_526,node_526,node_526);
                float3 directSpecular = attenColor * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularColor;
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = pow(max( 0.0, NdotL), node_526) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float4 _Snow_var = tex2D(_Snow,TRANSFORM_TEX(i.uv0, _Snow));
                float3 diffuseColor = ((_Color.rgb*lerp(_Color.rgb,_Snow_var.rgb,node_3801))*_BaseColor.rgb);
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(lerp(sceneColor.rgb, finalColor,lerp(node_522,1.0,_Opacity)),1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdadd
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _GrabTexture;
            uniform float _Opacity;
            uniform float _Invisibility;
            uniform fixed _LocalGlobal;
            uniform sampler2D _NormalMap1; uniform float4 _NormalMap1_ST;
            uniform sampler2D _NormalMap2; uniform float4 _NormalMap2_ST;
            uniform float _PlanetDarkness;
            uniform float _ColorSeep;
            uniform float _Gloss;
            uniform sampler2D _Snow; uniform float4 _Snow_ST;
            uniform float4 _Color;
            uniform float _WhiteAdded;
            uniform float4 _BaseColor;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                float4 projPos : TEXCOORD5;
                LIGHTING_COORDS(6,7)
                UNITY_FOG_COORDS(8)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float4 _NormalMap1_var = tex2D(_NormalMap1,TRANSFORM_TEX(i.uv0, _NormalMap1));
                float4 _NormalMap2_var = tex2D(_NormalMap2,TRANSFORM_TEX(i.uv0, _NormalMap2));
                float3 _LocalGlobal_var = lerp( mul( unity_WorldToObject, float4(i.normalDir,0) ).xyz.rgb, i.normalDir, _LocalGlobal );
                float node_3801 = ((0.7*clamp(_PlanetDarkness,0,1)*saturate((((_LocalGlobal_var*abs(_LocalGlobal_var)).g-_NormalMap1_var.g)*_PlanetDarkness)))+(clamp(_NormalMap1_var.g,0,1)*_ColorSeep)); // Added freezing effect
                float3 normalLocal = lerp(_NormalMap1_var.rgb,_NormalMap2_var.rgb,node_3801);
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float node_522 = pow(1.0-max(0,dot(normalDirection, viewDirection)),_Invisibility);
                float2 sceneUVs = (i.projPos.xy / i.projPos.w) + (i.uv0*node_522);
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
///////// Gloss:
                float gloss = lerp(_Gloss,0.7,node_3801);
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float node_526 = lerp(_WhiteAdded,0.1,node_3801);
                float3 specularColor = float3(node_526,node_526,node_526);
                float3 directSpecular = attenColor * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularColor;
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = pow(max( 0.0, NdotL), node_526) * attenColor;
                float4 _Snow_var = tex2D(_Snow,TRANSFORM_TEX(i.uv0, _Snow));
                float3 diffuseColor = ((_Color.rgb*lerp(_Color.rgb,_Snow_var.rgb,node_3801))*_BaseColor.rgb);
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(finalColor * lerp(node_522,1.0,_Opacity),0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
