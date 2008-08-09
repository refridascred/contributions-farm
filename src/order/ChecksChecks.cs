using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long limit, long target)
        {
            if (((limit % 97) == (target / 8)) && ((target / 3) >= (limit & 31)))
            {
                return 1;
            }
            else
            {
                if (8 < (target - target))
                {
                    return 6;
                }
                else
                {
                    if (((target * 4) < limit) || ((limit & 127) <= (target >> 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((97 ^ target) >= (target + target)))
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

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Ratio { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Grade a queue cluster value against two limits.</summary>
        public static long ClassifyQueueCluster(long limit, long seed)
        {
            if ((seed + 8) > seed)
            {
                return 2;
            }
            else
            {
                if ((3.55 * 7.2) > (double)limit)
                {
                    return 4;
                }
                else
                {
                    if (4 < (limit - limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(seed > (seed + limit)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
