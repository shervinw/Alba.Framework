﻿using System;
using Alba.Framework.Text;

namespace Alba.Framework.Common
{
    public class NamedObject
    {
        private string _name;

        public NamedObject (string name)
        {
            if (name.IsNullOrEmpty())
                throw new ArgumentNullException(name);
            _name = name;
        }

        public override string ToString ()
        {
            if (_name[0] != '{')
                _name = "{{{0}}}".FmtInv(_name);
            return _name;
        }
    }
}