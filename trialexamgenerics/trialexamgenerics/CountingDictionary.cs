using System;
using System.Collections.Generic;

namespace trialexamgenerics
{
    public class CountingDictionary<T>
    {
        private readonly IDictionary<T, int> _dict = new Dictionary<T, int>();

        public int Count { get { return _dict.Count; } }

        public int Add(T str)
        {
            if (_dict.ContainsKey(str))
            {
                int howMany = _dict[str] + 1;
                _dict[str] = howMany;
                return howMany;
            }
            _dict[str] = 1;
            return 1;
        }

        public int Get(T str)
        {
            if (_dict.ContainsKey(str))
            {
                return _dict[str];
            }
            return 0;
        }

        public int Remove(T str)
        {
            if (_dict.ContainsKey(str))
            {
                int howMany = _dict[str] - 1;
                if (howMany == 0)
                {
                    _dict.Remove(str);
                }
                else
                {
                    _dict[str] = howMany;
                }
                return howMany;
            }
            return -1;
        }
    }
}