﻿using System;
using FmbLib;
using System.IO;

#if XNA
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#else
#warning FmbLib slim XNA still WIP.
#endif

namespace FmbLib.TypeHandlers.Xna {
    public class Vector2Handler : TypeHandler<Vector2> {

        public override object Read(BinaryReader reader, bool xnb) {
            return new Vector2() {
                X = reader.ReadSingle(),
                Y = reader.ReadSingle()
            };
        }

        public override void Write(BinaryWriter writer, object obj_) {
            writer.Write((float) ((Vector2) obj_).X);
            writer.Write((float) ((Vector2) obj_).Y);
        }
    }
}
