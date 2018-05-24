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
               //先隐藏尾巴
               fnp_showtail(false);

              
          }
          Vector3 m_goto;
          protected virtual void fnp_moveTo()
          {
               m_player.DOMove(m_goto, Random.RandomRange(0.1f, 0.2f)).SetEase(Ease.InSine);
               //显示拖尾
               fnp_showtail();
          }
          public GameObject m_tail = null;
          public bool m_showTail = true;
          protected virtual void fnp_showtail(bool _show=true)
          {
               if (m_showTail && m_tail!=null)
               {
                    m_tail.SetActive(_show);
               }
          }
     } 
}
