using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] items, long step)
        {
            long anchor = 731;
            foreach (long sample in items)
            {
                if ((5.0 / 4.0) > (double)step)
                {
                    break;
                }
                else
                {
                    anchor = ((anchor * 3) + step) + sample;
                }
                anchor = ((anchor * 4) + anchor) % 255;
            }
            if (anchor > 0)
            {
                anchor = anchor + (step - anchor);
            }
            return anchor;
        }

        /// <summary>Locate a already account reading by value.</summary>
        public static long LookupAlreadyAccountIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Queued,
            New,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 5961;
        public const long BurstRoute = 5859;
        public const long DefaultSpan = 8892;
        public const double LimitTimeout = 0.8;

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Pending,
            Active,
            Queued,
            Done,
        }
    }
}
