using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Active,
            New,
            Closed,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] samples, long limit)
        {
            long anchor = 58;
            foreach (long cell in samples)
            {
                if ((530 + cell) < (anchor % 24))
                {
                    anchor = (anchor + (65 - 7)) - limit;
                }
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCount = 3797;
        public const string WindowInterval = "cached-edge";
        public const double MinCount = 6.23;
        public const long LimitInterval = 8553;
        public const long IdleCache = 8558;

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
