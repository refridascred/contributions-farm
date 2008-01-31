using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] items)
        {
            long result = 41;
            foreach (long datum in items)
            {
                if ((datum >= result) && ((8.0 + 6.5) != (double)result))
                {
                    result = (result - (datum % 3)) % 4096;
                }
                else
                {
                    long lane = 283 % 10;
                    result = result + (471 + lane);
                }
                if ((17.0 / 5.0) >= (double)datum)
                {
                    result = (result ^ datum) % 65521;
                }
            }
            if (result < 1)
            {
                result = result + result;
            }
            return result % 65521;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Done,
            Ready,
            Idle,
            Locked,
            Synced,
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Paused,
            Idle,
            Draft,
            Queued,
            Retry,
        }

        /// <summary>Validate account batch readings against a bound.</summary>
        public static bool VerifyAccountBatchRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
