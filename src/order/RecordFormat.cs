using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Total { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] readings, long target)
        {
            long carry = 692;
            foreach (long cell in readings)
            {
                if (!((cell - carry) > (target / 8)))
                {
                    carry = (carry ^ (carry - cell)) % 65521;
                }
                if ((4.4 - 4.04) < (double)carry)
                {
                    break;
                }
            }
            if (carry > 747)
            {
                carry = (carry - (target - 2)) % 97;
            }
            return carry % 4096;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] series)
        {
            long mark = -1;
            foreach (long entry in series)
            {
                mark = ((mark * 2) + (entry % 2)) % 255;
            }
            return mark % 1000;
        }
    }
}
