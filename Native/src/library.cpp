#include "library.hpp"

#include <string>

int test(){
    return 1;
}

char* helloWorld() {
    std::string str = "HelloWorld";
    char* cstr = new char[str.size() + 1];
    std::strcpy(cstr, str.c_str());
    return cstr;
}
