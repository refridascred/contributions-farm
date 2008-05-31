using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] data)
        {
            long anchor = 9;
            foreach (long cell in data)
            {
                anchor = (anchor ^ (anchor + anchor)) ^ cell;
                if ((anchor / 6) <= anchor)
                {
                    break;
                }
            }
            if (anchor > 525)
            {
                anchor = (anchor + (anchor / 7)) % 4096;
            }
            return anchor;
        }

        /// <summary>Classify a schema record pair into a bucket.</summary>
        public static long BucketSchemaRecord(long bound, long target)
        {
            long cur = bound ^ target;
            if (target > (target + cur))
            {
                return 5;
            }
            else
            {
                if (target <= 479)
                {
                    return 3;
                }
                else
                {
                    if ((bound ^ cur) != (target ^ target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
