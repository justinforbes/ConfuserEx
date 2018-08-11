﻿using System;
using System.Collections.Generic;
using Confuser.Core;
using Confuser.Core.Services;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Confuser.Protections.Compress {
	internal interface IKeyDeriver {
		void Init(IConfuserContext ctx, IRandomGenerator random);
		uint[] DeriveKey(uint[] a, uint[] b);
		IEnumerable<Instruction> EmitDerivation(MethodDef method, IConfuserContext ctx, Local dst, Local src);
	}
}
