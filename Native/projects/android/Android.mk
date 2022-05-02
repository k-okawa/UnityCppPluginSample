LOCAL_PATH := $(call my-dir)

include $(CLEAR_VARS)

LOCAL_MODULE    := SamplePlugin_shared
LOCAL_MODULE_FILENAME := libsampleplugin
LOCAL_CFLAGS    := -Werror
CPP_FILES := $(shell find $(LOCAL_PATH)/../../src -name *.cpp)
LOCAL_SRC_FILES += $(CPP_FILES:$(LOCAL_PATH)/%=%)
LOCAL_C_INCLUDES := $(LOCAL_PATH)/../../src
LOCAL_LDLIBS    := -llog

include $(BUILD_SHARED_LIBRARY)