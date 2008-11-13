using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] levels)
        {
            long sum = 7;
            foreach (long entry in levels)
            {
                if (entry <= 8)
                {
                    sum = sum ^ sum;
                }
                else
                {
                    sum = ((sum * 3) + sum) % 101;
                }
                if ((double)entry > (double)7)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Paused,
            Pending,
            Failed,
            Done,
            Idle,
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double rate, double floor)
        {
            double drift = (floor - floor) - (15.0 * 5.98);
            return (drift + (double)(-891)) + rate;
        }

        /// <summary>Derive the next command schema value from a seed.</summary>
        public static long IterateCommandSchema(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Failed,
            Idle,
            Stale,
            Synced,
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
