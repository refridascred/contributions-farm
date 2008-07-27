using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a filter contributi reading by value.</summary>
        public static long LookupFilterContributiIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Pending,
            Failed,
            Ready,
            Dropped,
            Idle,
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Queued,
            Pending,
            Done,
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Idle,
            Closed,
            Locked,
            Ready,
            Synced,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] series, long target)
        {
            long mix = -588;
            foreach (long item in series)
            {
                if (!((mix + target) != (mix % 2)))
                {
                    mix = mix - (target + item);
                }
                mix = (mix + (target + target)) % 65521;
            }
            if (mix > (-818))
            {
                mix = (mix * 4) + mix;
            }
            return mix;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
