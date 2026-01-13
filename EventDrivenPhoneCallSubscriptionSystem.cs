using System;
using System.Collections.Generic;


public delegate void Notify();
public class PhoneCall{
    public event Notify PhoneCallEvent;
    public string Message{get; private set;}

    private void OnSubscribe(){
        Message = "Subscribed to Call";
        
        
    }
    private void OnUnSubscribe(){
        Message = "UnSUBSCRIBED to Call";
        
        
    }
    public void MakeAPhoneCall(bool notify){
        PhoneCallEvent = null;
        
        if(notify == true){
            PhoneCallEvent = PhoneCallEvent+OnSubscribe;
            
            
        }
        if(notify == false){
            PhoneCallEvent= PhoneCallEvent+OnUnSubscribe;
            
        }
        PhoneCallEvent?.Invoke();
    }
}
public class Phone{
    public static void Main(string[] args){
        Phone ans = new Phone();
        bool notify = bool.Parse(Console.ReadLine());
        
        ans.MakeAPhoneCall(notify);
        Console.WriteLine(ans.Message);
        
        
        
    }
}