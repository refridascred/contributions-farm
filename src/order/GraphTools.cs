using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long seed, long target)
        {
            long edge = seed ^ target;
            if (((edge + 47) == (626 & 63)) && ((double)target >= (double)114))
            {
                return 6;
            }
            else
            {
                if ((seed - 41) == (744 % 7))
                {
                    return 3;
                }
                else
                {
                    if ((target * 3) > 2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 5231;
        public const long MaxSupport = 8042;
        public const string RetrySupport = "staging-1";

        /// <summary>Combine githubfarm batches values into a single score.</summary>
        public static long WeighGithubfarmBatches(long[] readings, long origin)
        {
            long carry = 1;
            foreach (long sample in readings)
            {
                if ((sample << 2) >= (carry & 127))
                {
                    carry = (carry ^ (origin & 7)) % 65521;
                }
            }
            if (carry > 0)
            {
                carry = ((carry << 3) ^ origin) % 255;
            }
            return carry;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] levels)
        {
            long mix = 650;
            foreach (long datum in levels)
            {
                mix = ((mix * 3) + (datum + datum)) % 1000;
                if (((double)datum < (8.8 / 8.0)) && (mix < (datum - mix)))
                {
                    mix = (mix << 2) ^ mix;
                }
                else
                {
                    mix = ((mix * 5) + (datum / 3)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!(((long)data.Length == (entry << 2)) || ((62 + floor) >= (entry * 2))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
