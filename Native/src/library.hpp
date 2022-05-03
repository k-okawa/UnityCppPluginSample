#ifndef SOURCE_LIBRARY_HPP
#define SOURCE_LIBRARY_HPP
#define _CRT_SECURE_NO_WARNINGS

#ifdef _WINDOWS
    #define _CRT_SECURE_NO_WARNINGS
    #define DLL_EXPORT __declspec(dllexport)
#elif
    #define DLL_EXPORT
#endif // _WINDOWS


extern "C"  {
    DLL_EXPORT int sum(int a, int b);
    DLL_EXPORT char* helloWorld();
};

#endif //SOURCE_LIBRARY_HPP
