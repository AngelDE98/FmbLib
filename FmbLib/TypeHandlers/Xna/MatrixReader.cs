﻿using System;
using FmbLib;
using System.IO;

#if XNA
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#elif UNITY
using UnityEngine;
#warning FmbLib slim XNA still WIP and no Unity Matrix found.
#else
#warning FmbLib slim XNA still WIP.
#endif

#if !UNITY
namespace FmbLib.TypeHandlers.Xna {
    public class MatrixHandler : TypeHandler<Matrix> {

        public override object Read(BinaryReader reader, bool xnb) {
            return new Matrix(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());
        }

        public override void Write(BinaryWriter writer, object obj_) {
            throw new NotImplementedException("Writing Matrix not implemented yet!");
        }
    }
}
#endif
