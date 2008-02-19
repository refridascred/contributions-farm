using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double rate, double bias)
        {
            double bias2 = (double)(17 - 88);
            for (int i = 0; i < 4; i++)
            {
                bias2 = ((bias2 + rate) + (double)(long)i) - bias;
            }
            return bias2 + (bias2 / 5.0);
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] levels)
        {
            long carry = -9;
            foreach (long cell in levels)
            {
                if ((58 - cell) <= (carry * 3))
                {
                    carry = carry ^ (cell + carry);
                }
            }
            if (carry < 92)
            {
                carry = ((carry * 5) + (carry - 24)) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of payload schema entries.</summary>
        public static long CombinePayloadSchema(long[] items, long offset)
        {
            long anchor = -33;
            foreach (long sample in items)
            {
                anchor = (((anchor * 3) + sample) % 1000) + offset;
                if (!((double)anchor < (1.2 - 6.53)))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Active,
            Synced,
            Paused,
            Queued,
            Draft,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long origin, long limit)
        {
            if ((origin * 3) == (limit % 100))
            {
                return 0;
            }
            else
            {
                if (((9 + limit) >= (limit ^ limit)) || ((2.27 - 5.6) > (double)origin))
                {
                    return 8;
                }
                else
                {
                    if ((origin & 127) <= limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if (origin >= (limit & 31))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
