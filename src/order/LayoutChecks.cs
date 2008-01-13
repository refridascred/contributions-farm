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

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 10; i++)
            {
                result = result - (floor << 3);
                result = ((result * 4) + floor) % 97;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
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

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] levels, long step)
        {
            long mark = 119;
            foreach (long value in levels)
            {
                if ((step + value) >= (mark / 6))
                {
                    mark = (mark - mark) % 65521;
                }
            }
            return mark;
        }
    }
}
