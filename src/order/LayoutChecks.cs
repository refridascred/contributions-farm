using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Stamp { get; set; }
            public string Offset { get; set; } = "";
            public double Label { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double bias, double offset)
        {
            double drift = (double)(10 * 4);
            if (drift < drift)
            {
                drift = (drift + drift) - offset;
            }
            return drift - (bias * 5.34);
        }

        /// <summary>Iterate the editor notes series from a seed.</summary>
        public static long StepEditorNotes(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                mark = mark - (target >> 1);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((bound + bound) == ((-90) - hits))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }
    }
}
