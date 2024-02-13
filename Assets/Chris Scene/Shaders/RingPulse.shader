// Shader created with Shader Forge v1.38 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
<<<<<<< HEAD
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:34218,y:32667,varname:node_3138,prsc:2|emission-6649-OUT,alpha-6958-OUT;n:type:ShaderForge.SFN_TexCoord,id:5316,x:31668,y:32724,varname:node_5316,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Slider,id:8352,x:31951,y:33014,ptovrint:False,ptlb:Radius,ptin:_Radius,varname:node_8352,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.1707977,max:1;n:type:ShaderForge.SFN_RemapRange,id:41,x:31849,y:32724,varname:node_41,prsc:2,frmn:0,frmx:1,tomn:-1,tomx:1|IN-5316-UVOUT;n:type:ShaderForge.SFN_Length,id:3051,x:32073,y:32724,cmnt:This went into subract prior,varname:node_3051,prsc:2|IN-41-OUT;n:type:ShaderForge.SFN_Subtract,id:2914,x:32415,y:32915,cmnt:Length went into here prior,varname:node_2914,prsc:2|A-7200-OUT,B-8352-OUT;n:type:ShaderForge.SFN_Divide,id:5086,x:33332,y:32912,varname:node_5086,prsc:2|A-184-OUT,B-4618-OUT;n:type:ShaderForge.SFN_DDXY,id:4084,x:32701,y:33196,varname:node_4084,prsc:2|IN-2914-OUT;n:type:ShaderForge.SFN_Abs,id:486,x:32610,y:32915,varname:node_486,prsc:2|IN-2914-OUT;n:type:ShaderForge.SFN_Slider,id:5137,x:32419,y:32821,ptovrint:False,ptlb:Thickness,ptin:_Thickness,varname:node_5137,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.01839735,max:0.1;n:type:ShaderForge.SFN_Subtract,id:184,x:32858,y:32915,varname:node_184,prsc:2|A-486-OUT,B-5137-OUT;n:type:ShaderForge.SFN_Clamp01,id:7985,x:33510,y:32912,varname:node_7985,prsc:2|IN-5086-OUT;n:type:ShaderForge.SFN_Slider,id:268,x:32528,y:33416,ptovrint:False,ptlb:PixelGlowSize,ptin:_PixelGlowSize,varname:node_268,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:1,cur:5,max:5;n:type:ShaderForge.SFN_Multiply,id:4618,x:32886,y:33196,varname:node_4618,prsc:2|A-4084-OUT,B-268-OUT;n:type:ShaderForge.SFN_OneMinus,id:6958,x:33689,y:32912,varname:node_6958,prsc:2|IN-7985-OUT;n:type:ShaderForge.SFN_Lerp,id:6649,x:33892,y:32676,varname:node_6649,prsc:2|A-7887-RGB,B-1982-RGB,T-6958-OUT;n:type:ShaderForge.SFN_Color,id:1982,x:33573,y:32651,ptovrint:False,ptlb:ColorInner,ptin:_ColorInner,cmnt:We can delete outer for 1 editable color,varname:node_1982,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Color,id:7887,x:33573,y:32461,ptovrint:False,ptlb:ColorOuter,ptin:_ColorOuter,cmnt:We can delete outer for 1 editable color,varname:node_7887,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.8018868,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Sin,id:653,x:32144,y:32435,varname:node_653,prsc:2|IN-4910-OUT;n:type:ShaderForge.SFN_Time,id:7347,x:31736,y:32435,varname:node_7347,prsc:2;n:type:ShaderForge.SFN_Multiply,id:4910,x:31949,y:32435,varname:node_4910,prsc:2|A-7347-TSL,B-3414-OUT;n:type:ShaderForge.SFN_Multiply,id:7200,x:32442,y:32524,varname:node_7200,prsc:2|A-6876-OUT,B-3051-OUT;n:type:ShaderForge.SFN_Slider,id:3414,x:31544,y:32610,ptovrint:False,ptlb:MovementSpeed,ptin:_MovementSpeed,cmnt:Edit max value for more speed here,varname:node_3414,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:6,max:10;n:type:ShaderForge.SFN_RemapRangeAdvanced,id:6876,x:32412,y:32263,varname:node_6876,prsc:2|IN-653-OUT,IMIN-8712-OUT,IMAX-5312-OUT,OMIN-5195-OUT,OMAX-9279-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5312,x:32218,y:32162,ptovrint:False,ptlb:StartMax,ptin:_StartMax,varname:node_5312,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_ValueProperty,id:8712,x:32218,y:32051,ptovrint:False,ptlb:StartMin,ptin:_StartMin,varname:node_8712,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:-1;n:type:ShaderForge.SFN_ValueProperty,id:9279,x:32446,y:32162,ptovrint:False,ptlb:SinMax,ptin:_SinMax,varname:node_9279,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:5195,x:32446,y:32051,ptovrint:False,ptlb:SinMin,ptin:_SinMin,varname:node_5195,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;proporder:8352-5137-268-1982-7887-3414-5312-8712-9279-5195;pass:END;sub:END;*/
=======
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:34218,y:32667,varname:node_3138,prsc:2|emission-6649-OUT,alpha-6958-OUT;n:type:ShaderForge.SFN_TexCoord,id:5316,x:31622,y:32818,varname:node_5316,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Slider,id:8352,x:31951,y:33014,ptovrint:False,ptlb:Radius,ptin:_Radius,varname:_Radius,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.1707977,max:1;n:type:ShaderForge.SFN_RemapRange,id:41,x:31849,y:32724,varname:node_41,prsc:2,frmn:0,frmx:1,tomn:-1,tomx:1|IN-5316-UVOUT;n:type:ShaderForge.SFN_Length,id:3051,x:32073,y:32724,cmnt:This went into subract prior,varname:node_3051,prsc:2|IN-41-OUT;n:type:ShaderForge.SFN_Subtract,id:2914,x:32415,y:32915,cmnt:Length went into here prior,varname:node_2914,prsc:2|A-7200-OUT,B-8352-OUT;n:type:ShaderForge.SFN_Divide,id:5086,x:33332,y:32912,varname:node_5086,prsc:2|A-184-OUT,B-4618-OUT;n:type:ShaderForge.SFN_DDXY,id:4084,x:32701,y:33196,varname:node_4084,prsc:2|IN-2914-OUT;n:type:ShaderForge.SFN_Abs,id:486,x:32610,y:32915,varname:node_486,prsc:2|IN-2914-OUT;n:type:ShaderForge.SFN_Slider,id:5137,x:32419,y:32821,ptovrint:False,ptlb:Thickness,ptin:_Thickness,varname:_Thickness,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.01839735,max:0.1;n:type:ShaderForge.SFN_Subtract,id:184,x:32858,y:32915,varname:node_184,prsc:2|A-486-OUT,B-5137-OUT;n:type:ShaderForge.SFN_Clamp01,id:7985,x:33510,y:32912,varname:node_7985,prsc:2|IN-5086-OUT;n:type:ShaderForge.SFN_Slider,id:268,x:32528,y:33416,ptovrint:False,ptlb:PixelGlowSize,ptin:_PixelGlowSize,varname:_PixelGlowSize,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:1,cur:5,max:5;n:type:ShaderForge.SFN_Multiply,id:4618,x:32886,y:33196,varname:node_4618,prsc:2|A-4084-OUT,B-268-OUT;n:type:ShaderForge.SFN_OneMinus,id:6958,x:33689,y:32912,varname:node_6958,prsc:2|IN-7985-OUT;n:type:ShaderForge.SFN_Lerp,id:6649,x:33892,y:32676,varname:node_6649,prsc:2|A-7887-RGB,B-1982-RGB,T-6958-OUT;n:type:ShaderForge.SFN_Color,id:1982,x:33573,y:32701,ptovrint:False,ptlb:ColorInner,ptin:_ColorInner,cmnt:We can delete outer for 1 editable color,varname:_ColorInner,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Color,id:7887,x:33573,y:32461,ptovrint:False,ptlb:ColorOuter,ptin:_ColorOuter,cmnt:We can delete outer for 1 editable color,varname:_ColorOuter,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.8018868,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Sin,id:653,x:32144,y:32435,varname:node_653,prsc:2|IN-4910-OUT;n:type:ShaderForge.SFN_Time,id:7347,x:31738,y:32328,varname:node_7347,prsc:2;n:type:ShaderForge.SFN_Multiply,id:4910,x:31949,y:32435,varname:node_4910,prsc:2|A-7347-TSL,B-3414-OUT;n:type:ShaderForge.SFN_Multiply,id:7200,x:32360,y:32524,varname:node_7200,prsc:2|A-653-OUT,B-3051-OUT;n:type:ShaderForge.SFN_Slider,id:3414,x:31532,y:32609,ptovrint:False,ptlb:MovementSpeed,ptin:_MovementSpeed,cmnt:Edit max value for more speed here,varname:_MovementSpeed,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:30,max:30;proporder:8352-5137-268-1982-7887-3414;pass:END;sub:END;*/
>>>>>>> main

Shader "Shader Forge/RingPulse" {
    Properties {
        _Radius ("Radius", Range(0, 1)) = 0.1707977
        _Thickness ("Thickness", Range(0, 0.1)) = 0.01839735
        _PixelGlowSize ("PixelGlowSize", Range(1, 5)) = 5
        _ColorInner ("ColorInner", Color) = (1,0,0,1)
        _ColorOuter ("ColorOuter", Color) = (0.8018868,0,0,1)
<<<<<<< HEAD
        _MovementSpeed ("MovementSpeed", Range(0, 10)) = 6
        _StartMax ("StartMax", Float ) = 1
        _StartMin ("StartMin", Float ) = -1
        _SinMax ("SinMax", Float ) = 0
        _SinMin ("SinMin", Float ) = 1
=======
        _MovementSpeed ("MovementSpeed", Range(0, 30)) = 30
>>>>>>> main
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
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
            #pragma target 3.0
            uniform float _Radius;
            uniform float _Thickness;
            uniform float _PixelGlowSize;
            uniform float4 _ColorInner;
            uniform float4 _ColorOuter;
            uniform float _MovementSpeed;
            uniform float _StartMax;
            uniform float _StartMin;
            uniform float _SinMax;
            uniform float _SinMin;
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
                float4 node_7347 = _Time;
                float node_2914 = (((_SinMin + ( (sin((node_7347.r*_MovementSpeed)) - _StartMin) * (_SinMax - _SinMin) ) / (_StartMax - _StartMin))*length((i.uv0*2.0+-1.0)))-_Radius); // Length went into here prior
                float node_6958 = (1.0 - saturate(((abs(node_2914)-_Thickness)/(fwidth(node_2914)*_PixelGlowSize))));
                float3 emissive = lerp(_ColorOuter.rgb,_ColorInner.rgb,node_6958);
                float3 finalColor = emissive;
                return fixed4(finalColor,node_6958);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
