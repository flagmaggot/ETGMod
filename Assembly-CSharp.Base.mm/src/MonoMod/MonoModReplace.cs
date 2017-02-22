﻿using System;

namespace MonoMod {
    /// <summary>
    /// MonoMod replace attribute.
    /// Apply it onto a method and no orig_ method will be generated by MonoMod.
    /// Apply it onto a field and its attributes / field type will be replaced by MonoMod.
    /// </summary>
    public class MonoModReplace : Attribute {
    }
}

