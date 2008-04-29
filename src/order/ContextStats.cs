using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 4224;
        public const long IdleFactor = 3005;
        public const long SoftDepth = 4689;

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] series)
        {
            long result = 7;
            foreach (long reading in series)
            {
                result = ((result * 3) + (reading % 64)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Grade a queue report value against two limits.</summary>
        public static long SortQueueReport(long target, long step)
        {
            long delta = target ^ step;
            if ((double)target >= (5.0 + 6.45))
            {
                return 5;
            }
            else
            {
                if (((target * 3) <= (delta + 804)) || (9.0 < (double)target))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Level { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
