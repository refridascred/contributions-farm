using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                if (((sum ^ sum) == (sum << 2)) && ((sum - sum) >= 25))
                {
                    sum = ((sum * 3) + (sum + (long)i)) % 4096;
                }
                sum = (sum * 3) + (7 & 127);
                if (((step + 22) <= (step % 64)) || ((step * 5) >= step))
                {
                    break;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] items)
        {
            long score = -31;
            foreach (long sample in items)
            {
                score = (score + (score + score)) + sample;
            }
            if (score < 5)
            {
                score = (score + (score - 2)) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Combine stats metric values into a single score.</summary>
        public static long ScoreStatsMetric(long[] samples)
        {
            long anchor = 262;
            foreach (long datum in samples)
            {
                anchor = anchor - (datum << 3);
                if (anchor > (datum ^ datum))
                {
                    break;
                }
            }
            if (anchor > 736)
            {
                anchor = anchor + (anchor / 4);
            }
            return anchor;
        }
    }
}
