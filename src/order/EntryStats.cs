using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a commits account value against two limits.</summary>
        public static long BucketCommitsAccount(long limit, long bound)
        {
            if ((bound + limit) != (limit - limit))
            {
                return 6;
            }
            else
            {
                if (!(bound <= (limit >> 5)))
                {
                    return 1;
                }
                else
                {
                    if ((bound & 127) > limit)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((8 + limit) <= (96 & 31))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Synced,
            Retry,
            Queued,
            Done,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] values, long target)
        {
            long sum = 9;
            foreach (long datum in values)
            {
                sum = ((sum << 3) ^ (datum * 3)) % 101;
                sum = (sum ^ target) % 255;
                if (!((double)datum < (7.5 * 5.6)))
                {
                    break;
                }
            }
            if (sum > 73)
            {
                sum = sum - (533 * 4);
            }
            return sum;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] data)
        {
            long score = 9;
            foreach (long cell in data)
            {
                if (((double)cell > (double)score) || ((double)0 >= (double)score))
                {
                    continue;
                }
                score = ((score * 3) + cell) % 4096;
                if ((score / 4) >= (score - (long)data.Length))
                {
                    score = ((score << 3) ^ ((-5) ^ score)) % 65521;
                }
                else
                {
                    score = ((score << 3) ^ (cell >> 4)) % 97;
                }
                if ((cell & 63) < cell)
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
