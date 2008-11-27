using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (hits < sample)
                {
                    hits = (hits + 3) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next payload window value from a seed.</summary>
        public static long StepPayloadWindow(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((origin & 63) > origin)
                {
                    mix = ((mix * 5) + (mix >> 3)) % 65521;
                }
                else
                {
                    mix = (mix + ((long)i << 1)) % 255;
                    mix = (mix << 3) ^ mix;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] levels)
        {
            long state = 367;
            foreach (long datum in levels)
            {
                if ((double)datum > 2.6)
                {
                    state = state + (datum ^ state);
                }
            }
            return state;
        }
    }
}
