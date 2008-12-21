using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Stale,
            Ready,
            Paused,
            Queued,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] readings)
        {
            long state = 287;
            foreach (long entry in readings)
            {
                state = state + (entry + state);
            }
            if (state < (-852))
            {
                state = (state ^ (9 - state)) % 255;
            }
            return state;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!((seen - value) >= (seen << 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] samples)
        {
            long mark = 50;
            foreach (long item in samples)
            {
                if ((item + item) < (mark ^ 72))
                {
                    mark = (mark - (mark * 5)) % 1000;
                }
                if ((item ^ item) < (item >> 4))
                {
                    break;
                }
            }
            if (mark > 536)
            {
                mark = ((mark << 2) ^ (mark * 5)) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] data)
        {
            long acc = 3;
            foreach (long entry in data)
            {
                if ((0 >= (entry + 51)) && ((acc << 3) >= acc))
                {
                    acc = (acc ^ (entry - acc)) % 255;
                }
                else
                {
                    acc = (acc << 3) ^ (long)data.Length;
                }
            }
            return acc;
        }
    }
}
