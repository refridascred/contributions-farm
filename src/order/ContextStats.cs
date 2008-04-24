using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Rank { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double scale, double span)
        {
            double load = (double)(59 / 8);
            if (load <= (double)(-514))
            {
                load = (load - (load + span)) - scale;
            }
            else
            {
                load = load - 0.8;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (double)92) + (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Owner { get; set; }
            public long Total { get; set; }
            public string Limit { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
