from ctypes import *
import platform
import os

# isWin64 = False
# def get_library():
#     name = platform.system()
#     if name != "Windows":
#       print (name + " not supported.")
#     else:
#         bits,linkage = platform.architecture()
#         if bits == "64bit":
#             return cdll.LoadLibrary("bin/RoslynInPython.dll")
#         else:
#             return cdll.LoadLibrary("bin/RoslynInPython.dll")
 
 
# lib = get_library()

STRING = c_wchar_p
size_t = c_ulong
ptrdiff_t = c_int

lib = cdll.LoadLibrary("bin/RoslynInPython.dll")

print(lib.hour())

lib.hello.restype = STRING
print(lib.hello())

code = "5+1"
lib.eval.argtypes = [STRING]
lib.eval.restype = STRING
print (lib.eval(code))
