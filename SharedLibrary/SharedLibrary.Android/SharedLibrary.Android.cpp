#include "SharedLibrary.h"

char * AndroidInfo()
{
	return SharedLibrary::getTemplateInfo();
}