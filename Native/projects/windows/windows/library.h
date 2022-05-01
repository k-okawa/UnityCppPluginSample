#pragma once

#define _CRT_SECURE_NO_WARNINGS

extern "C" {
    __declspec(dllexport) int __stdcall test();
    __declspec(dllexport) char* __stdcall helloWorld();
};