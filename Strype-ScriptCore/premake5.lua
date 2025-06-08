StrypeDirectory = os.getenv("STRYPE_DIR")

include "../Coral"

project "Strype-ScriptCore"
	kind "SharedLib"
	language "C#"
	dotnetframework "net8.0"
	clr "Unsafe"
    targetdir("../bin/%{cfg.buildcfg}")
    objdir("../bin/%{cfg.buildcfg}/int")

	links {
		"Coral.Managed"
	}

	files {
		"/Source/**.cs",
	}