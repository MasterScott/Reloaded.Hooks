﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Tools;

namespace Reloaded.Hooks
{
    public class ReloadedHooksUtilities : IReloadedHooksUtilities
    {
        public byte[] AssembleAbsoluteJump(IntPtr target, bool is64bit) => Utilities.AssembleAbsoluteJump(target, is64bit);
        public byte[] AssemblePushReturn(IntPtr target, bool is64bit) => Utilities.AssemblePushReturn(target, is64bit);
        public byte[] AssembleRelativeJump(IntPtr relativeJumpOffset, bool is64bit) => Utilities.AssembleRelativeJump(relativeJumpOffset, is64bit);

        public string GetAbsoluteJumpMnemonics(IntPtr target, bool is64bit) => Utilities.GetAbsoluteJumpMnemonics(target, is64bit);
        public string GetAbsoluteCallMnemonics(IntPtr target, bool is64bit) => Utilities.GetAbsoluteCallMnemonics(target, is64bit);

        public string GetAbsoluteJumpMnemonics<TFunction>(TFunction function, out IReverseWrapper<TFunction> reverseWrapper) where TFunction : Delegate => Utilities.GetAbsoluteJumpMnemonics(function, out reverseWrapper);
        public string GetAbsoluteCallMnemonics<TFunction>(TFunction function, out IReverseWrapper<TFunction> reverseWrapper) where TFunction : Delegate => Utilities.GetAbsoluteCallMnemonics(function, out reverseWrapper);
        public string GetPushReturnMnemonics(IntPtr target, bool is64bit) => Utilities.GetPushReturnMnemonics(target, is64bit);
        public string GetRelativeJumpMnemonics(IntPtr relativeJumpOffset, bool is64bit) => Utilities.GetRelativeJumpMnemonics(relativeJumpOffset, is64bit);

        public IntPtr InsertJump(byte[] opcodes, bool is64bit, long jumpTarget, long targetAddress = 0, long maxDisplacement = Int32.MaxValue) => Utilities.InsertJump(opcodes, is64bit, jumpTarget, targetAddress, maxDisplacement);
        public int GetHookLength(IntPtr hookAddress, int hookLength, bool is64Bit) => Utilities.GetHookLength(hookAddress, hookLength, is64Bit);

        public int GetNumberofParameters(Type delegateType) => Utilities.GetNumberofParameters(delegateType);
        public int GetNumberofParametersWithoutFloats(Type delegateType) => Utilities.GetNumberofParametersWithoutFloats(delegateType);

        public (long min, long max) GetRelativeJumpMinMax(long targetAddress, long maxDisplacement = Int32.MaxValue) => Utilities.GetRelativeJumpMinMax(targetAddress, maxDisplacement);
    }
}
