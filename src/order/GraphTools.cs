using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Score { get; set; }
            public double Rank { get; set; }
        }

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

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long limit, long step)
        {
            if ((double)step != (7.7 + 9.0))
            {
                return 5;
            }
            else
            {
                if (limit < (step % 8))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
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
