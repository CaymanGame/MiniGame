using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
namespace Fight
{
     public class N_playMove01 : AB_playMove
     {

          Transform m_player = null;
          public override void fn_move(Vector3 _worldpos)
          {
               if (m_player==null)
               {
                    m_player = this.gameObject.transform;
               }
               m_goto = _worldpos;
               m_player.DOLookAt(_worldpos, 0.35f).OnComplete(fnp_moveTo);

              
          }
          Vector3 m_goto;
          protected virtual void fnp_moveTo()
          {
               m_player.DOMove(m_goto, Random.RandomRange(0.1f, 0.2f)).SetEase(Ease.InSine);
          }
     } 
}
