﻿using System;

namespace Whitebox.Model
{
    [Serializable]
    public class TypeModel
    {
        readonly string _id;
        readonly bool _isDisposable;
        readonly string _assemblyQualifiedName;

        public TypeModel(string id, string assemblyQualifiedName, bool isDisposable)
        {
            if (id == null) throw new ArgumentNullException("id");
            if (assemblyQualifiedName == null) throw new ArgumentNullException("assemblyQualifiedName");
            _id = id;
            _assemblyQualifiedName = assemblyQualifiedName;
            _isDisposable = isDisposable;
        }

        public bool IsDisposable
        {
            get { return _isDisposable; }
        }

        public string Id
        {
            get { return _id; }
        }

        public string AssemblyQualifiedName
        {
            get { return _assemblyQualifiedName; }
        }
    }
}
