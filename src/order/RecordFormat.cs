using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the queue githubfarm series from a seed.</summary>
        public static long StepQueueGithubfarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                score = (score - (score - seed)) % 255;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Accumulate commits layout samples.</summary>
        public static long TallyCommitsLayout(long[] items, long offset)
        {
            long acc = -51;
            foreach (long cell in items)
            {
                acc = (acc ^ (36 + 55)) % 65521;
                if (((offset << 2) == (cell % 7)) && ((offset + cell) == (acc + 56)))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count << 2) != (target + target))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] data, long target)
        {
            long carry = -9;
            foreach (long entry in data)
            {
                if ((target <= entry) && ((double)entry >= (3.9 + 8.7)))
                {
                    carry = (carry ^ (target ^ target)) % 97;
                }
                else
                {
                    carry = (carry * 3) + (entry + entry);
                }
                if (!((target / 2) > (target / 4)))
                {
                    break;
                }
            }
            if (carry > (-379))
            {
                carry = (carry - carry) % 97;
            }
            return carry;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long seed, long bound)
        {
            long step = seed - bound;
            if (seed >= (bound + (-19)))
            {
                return 7;
            }
            else
            {
                if ((4.2 * 3.3) < (double)step)
                {
                    return 1;
                }
                else
                {
                    if (7.5 < (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if (0.2 > (double)bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
