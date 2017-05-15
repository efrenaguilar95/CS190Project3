#if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.
/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class Iterator : IDisposable {
  private IntPtr swigCPtr;
  protected bool swigCMemOwn;

  internal Iterator(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  internal static IntPtr getCPtr(Iterator obj) {
    return (obj == null) ? IntPtr.Zero : obj.swigCPtr;
  }

  ~Iterator() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AkSoundEnginePINVOKE.CSharp_delete_Iterator(swigCPtr);
        }
        swigCPtr = IntPtr.Zero;
      }
      GC.SuppressFinalize(this);
    }
  }

  public PlaylistItem pItem {
    set {
      AkSoundEnginePINVOKE.CSharp_Iterator_pItem_set(swigCPtr, PlaylistItem.getCPtr(value));

    } 
    get {
      IntPtr cPtr = AkSoundEnginePINVOKE.CSharp_Iterator_pItem_get(swigCPtr);
      PlaylistItem ret = (cPtr == IntPtr.Zero) ? null : new PlaylistItem(cPtr, false);

      return ret;
    } 
  }

  public Iterator NextIter() {
    Iterator ret = new Iterator(AkSoundEnginePINVOKE.CSharp_Iterator_NextIter(swigCPtr), false);

    return ret;
  }

  public Iterator PrevIter() {
    Iterator ret = new Iterator(AkSoundEnginePINVOKE.CSharp_Iterator_PrevIter(swigCPtr), false);

    return ret;
  }

  public PlaylistItem GetItem() {
    PlaylistItem ret = new PlaylistItem(AkSoundEnginePINVOKE.CSharp_Iterator_GetItem(swigCPtr), false);

    return ret;
  }

  public bool IsEqualTo(Iterator in_rOp) {
    bool ret = AkSoundEnginePINVOKE.CSharp_Iterator_IsEqualTo(swigCPtr, Iterator.getCPtr(in_rOp));

    return ret;
  }

  public bool IsDifferentFrom(Iterator in_rOp) {
    bool ret = AkSoundEnginePINVOKE.CSharp_Iterator_IsDifferentFrom(swigCPtr, Iterator.getCPtr(in_rOp));

    return ret;
  }

  public Iterator() : this(AkSoundEnginePINVOKE.CSharp_new_Iterator(), true) {

  }

}
#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.