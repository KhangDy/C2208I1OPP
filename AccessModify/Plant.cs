﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AccessModify;
public class Plant
{
    private void Private() => Console.WriteLine("private");
    protected void Protected() => Console.WriteLine("protected");
    internal void Internal() => Console.WriteLine("internal");
    private protected void PrivateProtected() => Console.WriteLine("private protected");
    protected internal void ProtectedInternal() => Console.WriteLine("protected internal");
    public void Public() => Console.WriteLine("public");
}