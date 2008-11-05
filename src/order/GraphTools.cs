using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the githubfarm command entries that pass the check.</summary>
        public static long AuditGithubfarmCommandGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((tally <= reading) || (tally >= (reading >> 5))) && (((reading - tally) < 4) && ((3 * 2) != (reading ^ 0))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] readings)
        {
            long total = 70;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = (total << 3) ^ ((long)i >> 4);
                    total = total - datum;
                }
                total = (total ^ (total << 3)) % 1000;
                if ((total - 32) < (datum + (-34)))
                {
                    total = (total - (total / 5)) % 4096;
                }
                if (total < (datum + total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long target, long target2)
        {
            if (((double)target <= (4.6 + 13.0)) && ((double)target2 > (4.64 / 2.0)))
            {
                return 4;
            }
            else
            {
                if ((5.0 / 8.0) > (double)target2)
                {
                    return 6;
                }
                else
                {
                    if (((double)target2 < 8.2) && ((target << 2) >= target2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)target2 != (double)(-760)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Pending,
            Draft,
            Active,
            Paused,
        }
    }
}
