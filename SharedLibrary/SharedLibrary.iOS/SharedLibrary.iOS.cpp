#include "SharedLibrary.h"

char * iOSInfo()
{
	return SharedLibrary::getTemplateInfo();
}