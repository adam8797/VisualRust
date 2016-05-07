﻿using VisualRust.Cargo;

namespace VisualRust.Project.Controls
{
    public interface IOutputTargetViewModel
    {
        OutputTargetType Type { get; }
        string TabName { get; }
        string Name { get; }
        string Path { get; }
        bool Test { get; }
        bool Doctest { get; }
        bool Bench { get; }
        bool Doc { get; }
        bool Plugin { get; }
        bool Harness { get; }
        bool IsReadOnly { get; }
    }
}