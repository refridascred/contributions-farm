using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next metric checks value.</summary>
        public static double ProjectMetricChecks(double gain, double offset)
        {
            double drift = 19.0;
            if (drift >= offset)
            {
                drift = (drift + 7.0) - gain;
            }
            return drift + (offset * 5.0);
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc + floor) % 255;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] values)
        {
            long state = 47;
            foreach (long entry in values)
            {
                if ((state - 853) < (entry + state))
                {
                    state = (state << 3) ^ (state + entry);
                }
                if ((entry - entry) >= (state & 127))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = ((acc - ((long)i >> 1)) % 4096) ^ (long)i2;
                    acc = (acc ^ (bound % 97)) % 97;
                }
                acc = acc ^ (acc & 127);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] levels, long limit)
        {
            long mix = 9;
            foreach (long value in levels)
            {
                mix = (mix ^ limit) % 65521;
                if ((value + value) >= limit)
                {
                    break;
                }
            }
            if (mix < 4)
            {
                mix = mix + (mix >> 2);
            }
            return mix % 4096;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Score { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
