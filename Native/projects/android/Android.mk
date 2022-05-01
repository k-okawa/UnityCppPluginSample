LOCAL_PATH := $(call my-dir)

include $(CLEAR_VARS)

LOCAL_MODULE    := SamplePlugin_shared
LOCAL_MODULE_FILENAME := SamplePlugin
LOCAL_CFLAGS    := -Werror
CPP_FILES := $(LOCAL_PATH)/../../src/library.cpp
LOCAL_SRC_FILES := $(LOCAL_PATH)/../../src/library.cpp
LOCAL_C_INCLUDES := $(LOCAL_PATH)/../../src
LOCAL_LDLIBS    := -llog

include $(BUILD_SHARED_LIBRARY)