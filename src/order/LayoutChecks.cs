using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Region { get; set; }
            public double Offset { get; set; }
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] levels, long seed)
        {
            long mark = 8;
            foreach (long cell in levels)
            {
                mark = ((mark << 2) ^ (seed + seed)) + cell;
            }
            return mark;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double gain, double offset)
        {
            double scale = (gain - gain) + (gain + offset);
            if (scale >= (offset / 9.0))
            {
                scale = scale - (offset / 5.0);
            }
            return scale - (scale / 3.0);
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Pending,
            Active,
            Failed,
            Idle,
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long step)
        {
            long total = step;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
