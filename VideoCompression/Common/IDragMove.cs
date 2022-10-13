using System;
using System.Windows.Input;

namespace VideoCompression.Common;
public interface IDragMove
{
    Action<object, MouseEventArgs> Move { get; set; }
}