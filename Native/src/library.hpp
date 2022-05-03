#ifndef SOURCE_LIBRARY_HPP
#define SOURCE_LIBRARY_HPP

#ifdef _WINDOWS
    #define _CRT_SECURE_NO_WARNINGS
    #define DLL_EXPORT __declspec(dllexport)
#endif

#ifndef _WINDOWS
    #define DLL_EXPORT
#endif


extern "C"  {
    DLL_EXPORT int sum(int a, int b);
    DLL_EXPORT char* helloWorld();
};

#endif //SOURCE_LIBRARY_HPP
