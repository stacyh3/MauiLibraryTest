#include "SharedLibrary.h"

#define PLATFORM_ANDROID 0
#define PLATFORM_IOS 1
#define PLATFORM_WINDWOS 2

#if PLATFORM == PLATFORM_WINDWOS
#define DLL_EXPORT __declspec(dllexport)
#else
#define DLL_EXPORT
#endif

extern "C"
{
	DLL_EXPORT int getData()
	{
		return PLATFORM;
	}
}