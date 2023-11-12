Shader "Ciconia Studio/CS_Standard/Builtin/Lite/Standard (Specular setup)/Opaque" {
	Properties {
		[Space(35)] [Header(Surface Options )] [Space(15)] [Enum(Off,2,On,0)] _Cull ("Double Sided", Float) = 0
		[Enum(Off,0,On,1)] _ZWrite ("ZWrite", Float) = 1
		[Enum(UnityEngine.Rendering.CompareFunction)] _ZTest ("ZTest", Float) = 4
		[Space(35)] [Header(Main Properties )] [Space(15)] _GlobalXYTilingXYZWOffsetXY ("Global --> XY(TilingXY) - ZW(OffsetXY)", Vector) = (1,1,0,0)
		_Color ("Color", Vector) = (1,1,1,0)
		[Toggle] _InvertABaseColor ("Invert Alpha", Float) = 0
		_MainTex ("Base Color", 2D) = "white" {}
		_Saturation ("Saturation", Float) = 0
		_Brightness ("Brightness", Range(1, 8)) = 1
		[Space(35)] _BumpMap ("Normal Map", 2D) = "bump" {}
		_BumpScale ("Normal Intensity", Float) = 0.3
		[Space(35)] _SpecularColor ("Specular Color", Vector) = (1,1,1,0)
		_SpecGlossMap ("Specular Map -->(Smoothness A)", 2D) = "white" {}
		_SpecularIntensity ("Specular Intensity", Range(0, 2)) = 0.2
		_Glossiness ("Smoothness", Range(0, 2)) = 0.5
		[Space(10)] [KeywordEnum(SpecularAlpha,BaseColorAlpha)] _Source ("Source", Float) = 0
		[Space(35)] _ParallaxMap ("Height Map", 2D) = "white" {}
		_Parallax ("Height Scale", Range(-0.1, 0.1)) = 0
		[Space(35)] _OcclusionMap ("Ambient Occlusion Map", 2D) = "white" {}
		_AoIntensity ("Ao Intensity", Range(0, 2)) = 1
		[Space(45)] [HDR] _EmissionColor ("Emission Color", Vector) = (0,0,0,0)
		_EmissionMap ("Emission Map", 2D) = "white" {}
		_EmissionIntensity ("Intensity", Range(0, 2)) = 1
		[Space(35)] [Header(Mask Properties)] [Toggle] _EnableDetailMask ("Enable", Float) = 0
		[Space(15)] [Toggle] _VisualizeMask ("Visualize Mask", Float) = 0
		[Toggle] _SourceMask ("Source - Use BaseColorAlpha", Float) = 0
		[Space(15)] [Toggle] _InvertMask ("Invert Mask", Float) = 0
		_DetailMask ("Detail Mask", 2D) = "black" {}
		_IntensityMask ("Intensity", Range(0, 1)) = 1
		[Space(15)] _ContrastDetailMap ("Contrast", Float) = 0
		_SpreadDetailMap ("Spread", Float) = 0
		[Space(35)] [Header(Detail Properties)] [Space(15)] _DetailColor ("Color  -->(Smoothness Intensity A)", Vector) = (1,1,1,0)
		_DetailAlbedoMap ("Base Color  -->(Smoothness A)", 2D) = "white" {}
		_DetailSaturation ("Saturation", Float) = 0
		_DetailBrightness ("Brightness", Range(1, 8)) = 1
		[Space(35)] [Toggle] _BlendMainNormal ("Blend Main Normal", Float) = 1
		_DetailNormalMap ("Normal Map", 2D) = "bump" {}
		_DetailNormalMapScale ("Scale", Float) = 0.3
		[HideInInspector] _texcoord ("", 2D) = "white" {}
		[HideInInspector] __dirty ("", Float) = 1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		fixed4 _Color;
		struct Input
		{
			float2 uv_MainTex;
		};
		
		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
	Fallback "Diffuse"
}