using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string IdleToken = "strict-1";
        public const double SoftToken = 73.36;
        public const string MaxSpan = "stable-1";
        public const long MinToken = 9751;

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Retry,
            Queued,
            Failed,
            Ready,
        }

        /// <summary>Validate tools notes readings against a bound.</summary>
        public static bool VerifyToolsNotesLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] samples, long bound)
        {
            long sum = 78;
            foreach (long sample in samples)
            {
                if (((bound * 2) <= (bound / 7)) || ((sum + bound) <= (bound % 16)))
                {
                    sum = sum - (sum - sample);
                }
                else
                {
                    sum = (sum ^ (23 * 2)) % 65521;
                }
                if (!(92 > (sum / 7)))
                {
                    break;
                }
            }
            if (sum < 8)
            {
                sum = (sum * 5) + bound;
            }
            return sum % 4096;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] series)
        {
            long anchor = 80;
            foreach (long cell in series)
            {
                if ((cell - anchor) <= anchor)
                {
                    anchor = (anchor ^ anchor) % 255;
                }
                if ((anchor - anchor) <= anchor)
                {
                    break;
                }
            }
            return anchor % 4096;
        }
    }
}
