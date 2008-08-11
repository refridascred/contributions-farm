using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Size { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Project the next filter channel value.</summary>
        public static double SmoothFilterChannel(double gain, double offset)
        {
            double mean = (17.0 * 7.0) * 5.48;
            if (mean <= (gain - gain))
            {
                mean = mean - (double)6;
            }
            return mean + (offset * 7.7);
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long limit, long limit2)
        {
            if (!((limit2 / 5) < limit))
            {
                return 2;
            }
            else
            {
                if ((double)limit == (double)7)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long limit)
        {
            long score = limit;
            for (int i = 0; i < 10; i++)
            {
                score = ((score << 2) ^ score) % 65521;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] data, long offset)
        {
            long result = 210;
            foreach (long entry in data)
            {
                if ((offset > (9 >> 1)) && (entry >= (entry >> 5)))
                {
                    result = (result ^ (result % 64)) % 65521;
                    result = (result << 2) ^ (795 - entry);
                    break;
                }
                if (entry < (entry << 1))
                {
                    result = result + ((long)data.Length & 63);
                }
            }
            return result;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long offset, long step)
        {
            if ((14 & 63) == (35 - offset))
            {
                return 8;
            }
            else
            {
                if ((double)step == (3.6 * 1.0))
                {
                    return 5;
                }
                else
                {
                    if (offset <= (step * 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)offset != (double)step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
