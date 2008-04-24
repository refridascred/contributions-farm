using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Roll a command schema counter forward.</summary>
        public static long IterateCommandSchema(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 10; i++)
            {
                if (!((acc - offset) <= (24 << 1)))
                {
                    acc = ((acc * 2) + (long)i) % 97;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Draft,
            Closed,
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Label { get; set; }
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
