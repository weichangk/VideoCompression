using System;

namespace VideoCompression.Common;
public interface IHeadOper
{
    Action Close { get; set; }
    Action Min { get; set; }
    Action Move { get; set; }
}
