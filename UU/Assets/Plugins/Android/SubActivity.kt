package com.unity3d.player

import android.app.Activity
import android.content.Context
import android.text.Editable
import android.text.TextWatcher
import android.view.LayoutInflater
import android.view.View
import android.view.inputmethod.InputMethodManager
import android.widget.*
import com.unity3d.player.UnityPlayer


class  SubActivity{
    companion object {

        lateinit var mContext : Activity
        lateinit var fl : FrameLayout
        lateinit var imm : InputMethodManager

        @JvmStatic fun SubFun(_mContext : Activity, activity_sub_id : Int, send_et_id : Int, send_btn_id : Int) {

            mContext = _mContext
            imm = mContext.getSystemService(Context.INPUT_METHOD_SERVICE) as InputMethodManager


            // activity_sub.xml 뷰 추가, 이후에 mContext.뷰를 가져올 수 있음
            val inflater = mContext.getSystemService(Context.LAYOUT_INFLATER_SERVICE) as LayoutInflater
            fl = inflater.inflate(activity_sub_id, null) as FrameLayout
            val paramll = FrameLayout.LayoutParams(FrameLayout.LayoutParams.MATCH_PARENT, FrameLayout.LayoutParams.MATCH_PARENT)
            mContext.addContentView(fl, paramll)

            val send_et_view = mContext.findViewById<EditText>(send_et_id)
            val send_btn_view = mContext.findViewById<Button>(send_btn_id)


            // 에딧텍스트 글자가 있으면 보내기 활성화
            send_et_view.addTextChangedListener(object : TextWatcher{
                override fun afterTextChanged(p0: Editable?) {}
                override fun beforeTextChanged(p0: CharSequence?, p1: Int, p2: Int, p3: Int) {}
                override fun onTextChanged(p0: CharSequence?, p1: Int, p2: Int, p3: Int) {
                    if(p0?.trim().toString() != "") send_btn_view.visibility = View.VISIBLE
                    else send_btn_view.visibility = View.GONE
                }
            })


            send_btn_view.setOnClickListener{

                // 호출할 게임오브젝트 이름, 함수명, 매개변수 하나
                UnityPlayer.UnitySendMessage("ChatMgr", "ReceiveMessage", send_et_view.text.toString())
                send_et_view.setText("")
            }

            LayoutVisible(false)
        }


        @JvmStatic fun LayoutVisible(isVisible : Boolean) {
            mContext.runOnUiThread{
                if(isVisible) fl.visibility = View.VISIBLE
                else
                {
                    fl.visibility = View.GONE
                    imm.hideSoftInputFromWindow(mContext.window.currentFocus?.windowToken, 0)
                }
            }
        }
    }
}