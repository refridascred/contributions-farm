using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Closed,
            Active,
            Pending,
            Done,
            Ready,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long offset, long origin)
        {
            if ((origin / 8) < (offset / 4))
            {
                return 3;
            }
            else
            {
                if ((origin <= (origin & 3)) || ((offset + offset) != (offset * 4)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long floor, long limit)
        {
            long gap = floor + limit;
            if ((limit >= (limit / 2)) && ((double)floor != (10.0 - 0.2)))
            {
                return 8;
            }
            else
            {
                if (((floor * 4) < 16) && ((floor ^ limit) == (gap - 868)))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit <= (4.1 + 15.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Ready,
            Synced,
            Idle,
        }
    }
}
