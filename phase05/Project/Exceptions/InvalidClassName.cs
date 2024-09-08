﻿using phase02.resources;

namespace phase02.Exceptions;

public class InvalidClassName : Exception
{
    public InvalidClassName() : base(Resources.InvalidClassNameMessage, new Exception())
    {
    }
}