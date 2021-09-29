﻿using System;
using System.Collections.Generic;

namespace TDDKata
{
    public class TennisGame
    {
        private readonly Dictionary<int, string> _pointSringMapping = new()
        {
            { 0, "Love" },
            { 1, "Fifteen" },
            { 2, "Thirty" },
            { 3, "Forty" }
        };

        private int _receiverPoint;

        private int _servicePoint;

        public string CurrentScore()
        {
            if (IsPointDifferent())
            {
                if (_servicePoint > 3 )
                {
                    if (Math.Abs(_servicePoint - _receiverPoint) == 1)
                    {
                        return "Service Adv";
                    }

                    return "Service Win";
                }
                return $"{_pointSringMapping[_servicePoint]} {_pointSringMapping[_receiverPoint]}";
            }

            return IsDeuce() ? "Deuce" : $"{_pointSringMapping[_servicePoint]} All";
        }

        private bool IsDeuce()
        {
            return _servicePoint > 2;
        }

        private bool IsPointDifferent()
        {
            return _servicePoint != _receiverPoint;
        }

        public void ServiceGetPoint(int times = 1)
        {
            for (var i = 0; i < times; i++)
            {
                _servicePoint++;
            }
        }

        public void ReceiverGetPoint(int times = 1)
        {
            for (var i = 0; i < times; i++)
            {
                _receiverPoint++;
            }
        }
    }
}