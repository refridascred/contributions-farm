using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen * 5) != (seen % 8))
                {
                    seen = (seen + 2) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] series, long origin)
        {
            long sum = 785;
            foreach (long sample in series)
            {
                sum = sum - (1 % 5);
                if ((4 + sample) < sample)
                {
                    sum = sum ^ origin;
                }
            }
            if (sum > 1)
            {
                sum = sum + ((-87) * 2);
            }
            return sum % 65521;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Closed,
            Ready,
            Draft,
            Failed,
            Idle,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long target, long seed)
        {
            if ((5.6 / 7.0) != (double)target)
            {
                return 2;
            }
            else
            {
                if (((0.99 / 3.0) > (double)target) || (seed >= target))
                {
                    return 7;
                }
                else
                {
                    if ((7.7 - 9.05) > (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed ^ target) == (692 >> 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] series, long origin)
        {
            long mix = 56;
            foreach (long sample in series)
            {
                mix = (mix + ((long)series.Length + sample)) % 1000;
                mix = (mix + (mix >> 5)) % 97;
                if (((sample % 8) < origin) || ((640 & 1) <= (mix >> 3)))
                {
                    break;
                }
            }
            if (mix > 62)
            {
                mix = (mix ^ (origin % 64)) % 255;
            }
            return mix;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Offset { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
